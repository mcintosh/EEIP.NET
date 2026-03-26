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

            /*

            //ushort[] cmd = new ushort[] { 192, 168, 0, 23, 502, 1, 0, 1, 0, 3, 4000 }; //Modbus command: see pp. 113-114 of the PLX31-EIP-MBTCP manual
            //ushort[] cmd = new ushort[] { 192, 168, 0, 23, 502, 1, 0, 1, 0, 3, 2000 }; //Modbus command: see pp. 113-114 of the PLX31-EIP-MBTCP manual
            ushort[] cmd = new ushort[] { 192, 168, 0, 23, 502, 1, 0, 1, 0, 3, 0 }; //Modbus command: see pp. 113-114 of the PLX31-EIP-MBTCP manual
            // Convert ushort[] to byte[]
            byte[] cmdBytes = new byte[cmd.Length * 2]; // Each ushort is 2 bytes
            Buffer.BlockCopy(cmd, 0, cmdBytes, 0, cmdBytes.Length);
            // Now use it
            //1, 2 is set -- 1,1 is get
            response = eeipClient.SetAttributeSingle(0x6F, 1, 2, cmdBytes); //send cmd to PLX31-EIP-MBTCP device, see pp. 113-114 of the PLX31-EIP-MBTCP manual

            System.Threading.Thread.Sleep(1000); //wait for the command to be executed
            response = eeipClient.GetAttributeSingle(0x6F, 1, 1); //get command execution status

            */

            // Example using WriteTag to write INT data to a tag <-- This is typically used with Allen-Bradley/Rockwell controllers ==========================
            try
            {
                // Write a single INT value (2 bytes), no offset
                ushort valueToWrite = 1234;
                byte[] writeData = BitConverter.GetBytes(valueToWrite);
                eeipClient.WriteTag("INT_DATA", writeData);
                Console.WriteLine("Successfully wrote value to INT_DATA tag");

                byte[] tagData = eeipClient.ReadTag("INT_DATA", 1);
                if (tagData.Length >= 2)
                {
                    ushort value = BitConverter.ToUInt16(tagData, 2); // Skip the first 2 bytes (data type code)
                    Console.WriteLine($"Read Tag Data: {value}");
                }

                // Or write multiple INT values (array of 5 elements)
                ushort[] intArray = new ushort[] { 77, 456, 789, 987, 654 };
                byte[] arrayData = new byte[intArray.Length * 2];
                Buffer.BlockCopy(intArray, 0, arrayData, 0, arrayData.Length);
                eeipClient.WriteTag("INT_DATA", arrayData);
                Console.WriteLine("Successfully wrote array to INT_DATA tag");

                // Read 5 elements of INT_DATA
                byte[] tagData2 = eeipClient.ReadTag("INT_DATA", 5);

                // Parse the results (1st 2 bytes are data type code)
                for (int i = 2; i < tagData2.Length; i += 2)
                {
                    ushort value = BitConverter.ToUInt16(tagData2, i);
                    Console.WriteLine($"Element {10 + (i / 2)}: {value}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Write Tag error: " + ex.Message);
            }

            /*
            // Example using Read Tag <--  This is typically used with Allen-Bradley/Rockwell controllers ===========================
            try
            {
                //byte[] arrayData = eeipClient.ReadTag("MyArray", 10);
                byte[] tagData = eeipClient.ReadTag("INT_DATA", 200); //this returns number of errors
                //Console.WriteLine("Read Tag Data (0x4C): " + BitConverter.ToString(tagData));

                // For reading a INT (2 bytes)
                if (tagData.Length >= 2)
                {
                    ushort numErrors = BitConverter.ToUInt16(tagData, 246);
                    Console.WriteLine("INT Value: " + numErrors);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Tag error: " + ex.Message);
            }
            */


            // Write to INT_DATA starting at element index 10
            ushort[] values = new ushort[] { 1, 2, 3, 4, 5 };
            byte[] arrayData1 = new byte[values.Length * 2];
            Buffer.BlockCopy(values, 0, arrayData1, 0, arrayData1.Length);
            eeipClient.WriteTag("INT_DATA[10]", 0xC3, arrayData1, (ushort)values.Length);
            Console.WriteLine("Successfully wrote 5 values starting at index 10");

            // Write a single value at index 100
            ushort singleVal = 9999;
            byte[] singleData = BitConverter.GetBytes(singleVal);
            eeipClient.WriteTag("INT_DATA[100]", 0xC3, singleData, 1);
            Console.WriteLine("Successfully wrote value at index 100");



            // Read 5 elements starting at index 10 of INT_DATA
            byte[] tagData1 = eeipClient.ReadTag("INT_DATA[10]", 5);

            // Parse the results (1st 2 bytes are data type code)
            for (int i = 2; i < tagData1.Length; i += 2)
            {
                ushort value = BitConverter.ToUInt16(tagData1, i);
                Console.WriteLine($"Element {10 + (i / 2)}: {value}");
            }

            // Read single element at index 100
            byte[] singleValue = eeipClient.ReadTag("INT_DATA[100]", 1);
            if (singleValue.Length >= 2)
            {
                ushort value = BitConverter.ToUInt16(singleValue, 2); // Skip the first 2 bytes (data type code)
                Console.WriteLine($"Element 100: {value}");
            }

            // Read single element at index 250
            byte[] heartBeatValue = eeipClient.ReadTag("INT_DATA[250]", 1);
            if (heartBeatValue.Length >= 2)
            {
                ushort value = BitConverter.ToUInt16(heartBeatValue, 2); // Skip the first 2 bytes (data type code)
                Console.WriteLine($"Heartbeat Value: {value}");
            }

            /*
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
            */

        }
    }
}
