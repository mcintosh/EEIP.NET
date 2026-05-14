using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sres.Net.EEIP;

namespace EEIPWinForms
{
    public partial class Form1 : Form
    {
        private EEIPClient eeipClient;
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected)
                {
                    eeipClient.UnRegisterSession();
                    isConnected = false;
                    btnConnect.Text = "Connect";
                    btnConnect.BackColor = Color.LightGreen;
                    lblStatus.Text = "Disconnected";
                    lblStatus.ForeColor = Color.Red;
                    Log("Disconnected.");
                    return;
                }

                eeipClient = new EEIPClient();
                eeipClient.IPAddress = txtIPAddress.Text.Trim();
                eeipClient.TCPPort = (ushort)nudPort.Value;
                eeipClient.RegisterSession();

                isConnected = true;
                btnConnect.Text = "Disconnect";
                btnConnect.BackColor = Color.Salmon;
                lblStatus.Text = "Connected";
                lblStatus.ForeColor = Color.Green;
                Log($"Connected to {eeipClient.IPAddress}:{eeipClient.TCPPort}");
            }
            catch (Exception ex)
            {
                Log($"Connection error: {ex.Message}");
                MessageBox.Show($"Connection error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tagName = txtWriteTagName.Text.Trim();
                int startIndex = (int)nudWriteStartIndex.Value;
                string[] rawValues = txtWriteValues.Text.Split(new char[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                List<ushort> values = new List<ushort>();
                foreach (string s in rawValues)
                {
                    if (ushort.TryParse(s.Trim(), out ushort val))
                        values.Add(val);
                    else
                        throw new Exception($"Invalid value: '{s.Trim()}'. Only unsigned integers (0-65535) are supported.");
                }

                if (values.Count == 0)
                    throw new Exception("No valid values entered.");

                byte[] dataBytes = new byte[values.Count * 2];
                Buffer.BlockCopy(values.ToArray(), 0, dataBytes, 0, dataBytes.Length);

                string fullTagName = $"{tagName}[{startIndex}]";
                eeipClient.WriteTag(fullTagName, 0xC3, dataBytes, (ushort)values.Count);

                Log($"Wrote {values.Count} value(s) to {fullTagName}: {string.Join(", ", values)}");
            }
            catch (Exception ex)
            {
                Log($"Write error: {ex.Message}");
                MessageBox.Show($"Write error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tagName = txtReadTagName.Text.Trim();
                int startIndex = (int)nudReadStartIndex.Value;
                ushort count = (ushort)nudReadCount.Value;

                string fullTagName = $"{tagName}[{startIndex}]";
                byte[] data = eeipClient.ReadTag(fullTagName, count);

                // First 2 bytes are data type code, skip them
                listViewResults.Items.Clear();
                int dataOffset = 2;
                for (int i = dataOffset; i + 1 < data.Length; i += 2)
                {
                    ushort value = BitConverter.ToUInt16(data, i);
                    int elementIndex = startIndex + ((i - dataOffset) / 2);
                    var item = new ListViewItem(elementIndex.ToString());
                    item.SubItems.Add(value.ToString());
                    item.SubItems.Add("0x" + value.ToString("X4"));
                    listViewResults.Items.Add(item);
                }

                Log($"Read {count} element(s) from {fullTagName}. Received {(data.Length - dataOffset) / 2} value(s).");
            }
            catch (Exception ex)
            {
                Log($"Read error: {ex.Message}");
                MessageBox.Show($"Read error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tagName = txtReadTagName.Text.Trim();
                int startIndex = (int)nudReadStartIndex.Value;
                ushort count = (ushort)nudReadCount.Value;

                // CIP max payload per request is ~480 bytes = 240 INT elements
                const int maxPerRequest = 240;
                listViewResults.Items.Clear();

                int remaining = count;
                int offset = 0;

                while (remaining > 0)
                {
                    ushort batchCount = (ushort)Math.Min(remaining, maxPerRequest);
                    int batchIndex = startIndex + offset;
                    string fullTagName = $"{tagName}[{batchIndex}]";

                    byte[] data = eeipClient.ReadTag(fullTagName, batchCount);

                    // First 2 bytes are data type code, skip them
                    const int dataOffset = 2;
                    int valuesReceived = (data.Length - dataOffset) / 2;

                    for (int i = 0; i < valuesReceived; i++)
                    {
                        ushort value = BitConverter.ToUInt16(data, dataOffset + i * 2);
                        int elementIndex = batchIndex + i;

                        var item = new ListViewItem(elementIndex.ToString());
                        item.SubItems.Add(value.ToString());
                        item.SubItems.Add("0x" + value.ToString("X4"));
                        listViewResults.Items.Add(item);
                    }

                    offset += valuesReceived;
                    remaining -= valuesReceived;

                    if (valuesReceived < batchCount)
                        break; // device returned fewer than requested, stop
                }

                Log($"Read {listViewResults.Items.Count} element(s) from {tagName}[{startIndex}].");
            }
            catch (Exception ex)
            {
                Log($"Read error: {ex.Message}");
                MessageBox.Show($"Read error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tagName = txtReadTagName.Text.Trim();
                int startIndex = (int)nudReadStartIndex.Value;
                ushort count = (ushort)nudReadCount.Value;

                const int maxPerRequest = 240;
                const int dataOffset = 2; // confirmed: first 2 bytes are data type code (e.g. C3-00 = INT)
                listViewResults.Items.Clear();

                int remaining = count;
                int offset = 0;

                while (remaining > 0)
                {
                    ushort batchCount = (ushort)Math.Min(remaining, maxPerRequest);
                    int batchIndex = startIndex + offset;
                    string fullTagName = $"{tagName}[{batchIndex}]";

                    byte[] data = eeipClient.ReadTag(fullTagName, batchCount);
                    int valuesReceived = (data.Length - dataOffset) / 2;

                    for (int i = 0; i < valuesReceived; i++)
                    {
                        ushort value = BitConverter.ToUInt16(data, dataOffset + i * 2);
                        int elementIndex = batchIndex + i;

                        var item = new ListViewItem(elementIndex.ToString());
                        item.SubItems.Add(value.ToString());
                        item.SubItems.Add("0x" + value.ToString("X4"));
                        listViewResults.Items.Add(item);
                    }

                    offset += valuesReceived;
                    remaining -= valuesReceived;

                    if (valuesReceived < batchCount)
                        break;
                }

                Log($"Read {listViewResults.Items.Count} element(s) from {tagName}[{startIndex}].");
            }
            catch (Exception ex)
            {
                Log($"Read error: {ex.Message}");
                MessageBox.Show($"Read error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            txtLog.AppendText($"[{timestamp}] {message}{Environment.NewLine}");
            txtLog.ScrollToCaret();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void nudWriteStartIndex_ValueChanged(object sender, EventArgs e)
        {
            // Modbus address = EIP index + 40001 - 1250 (base address for write holding registers)
            int modbusAddress = (int)nudWriteStartIndex.Value + 40001 - 1250;
            lblModbusWriteAddress.Text = $"({modbusAddress})";
        }

        private void nudReadStartIndex_ValueChanged(object sender, EventArgs e)
        {
            // Modbus address = EIP index + 40001 -250 (base address for read holding registers)
            int modbusAddress = (int)nudReadStartIndex.Value + 40001 - 250;
            lblModbusReadAddress.Text = $"({modbusAddress})";
        }
    }
}