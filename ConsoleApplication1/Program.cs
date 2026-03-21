using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sres.Net.EEIP;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {




            EEIPClient eeipClient = new EEIPClient();
            //eeipClient.IPAddress = "192.168.0.123";
            eeipClient.IPAddress = "192.168.0.250";
            eeipClient.RegisterSession();


            //eeipClient.TCPPort = 0xAF12; //Standard Port for Ethernet/IP TCP-connections
            eeipClient.TCPPort = 44818;
            byte[] response = eeipClient.GetAttributeAll(1, 1); //returns header id PLX31-EIP-MBTCP

            ushort[] cmd = new ushort[] { 192, 168, 0, 23, 502, 1, 0, 1, 0, 3, 4000 }; //Modbus command: see pp. 113-114 of the PLX31-EIP-MBTCP manual
            // Convert ushort[] to byte[]
            byte[] cmdBytes = new byte[cmd.Length * 2]; // Each ushort is 2 bytes
            Buffer.BlockCopy(cmd, 0, cmdBytes, 0, cmdBytes.Length);
            // Now use it
            response = eeipClient.SetAttributeSingle(0x6F, 1, 2, cmdBytes); //send Modbus cmd to PLX31-EIP-MBTCP device, see pp. 113-114 of the PLX31-EIP-MBTCP manual

            System.Threading.Thread.Sleep(1000); //wait for the command to be executed
            response = eeipClient.GetAttributeSingle(0x6F, 1, 1); //Modbus object: gets command execution status



            //byte[] response = eeipClient.GetAttributeSingle(0x66, 1, 0x325);


            Console.WriteLine("Current Value Sensor 1: " + (response[1] * 255 + response[0]).ToString());
            response = eeipClient.GetAttributeSingle(0x66, 2, 0x325);
            Console.WriteLine("Current Value Sensor 2: " + (response[1] * 255 + response[0]).ToString());
            Console.WriteLine();
            Console.Write("Enter intensity for Sensor 1 [1..100]");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Set Light intensity Sensor 1 to "+value+"%");
            eeipClient.SetAttributeSingle(0x66, 1, 0x389,new byte [] {(byte)value,0 });
            Console.Write("Enter intensity for Sensor 2 [1..100]");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine("Set Light intensity Sensor 2 to " + value + "%");
            eeipClient.SetAttributeSingle(0x66, 2, 0x389, new byte[] { (byte)value, 0 });
            Console.WriteLine();
            Console.WriteLine("Read Values from device to approve the value");
            response = eeipClient.GetAttributeSingle(0x66, 1, 0x389);
            Console.WriteLine("Current light Intensity Sensor 1 in %: " + (response[1] * 255 + response[0]).ToString());
            response = eeipClient.GetAttributeSingle(0x66, 2, 0x389);
            Console.WriteLine("Current light Intensity Sensor 2 in %: " + (response[1] * 255 + response[0]).ToString());
            eeipClient.UnRegisterSession();
            Console.ReadKey();
     
       
        }
    }
}
