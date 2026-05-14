namespace EEIPWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Connection controls
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblStatus;

        // Write controls
        private System.Windows.Forms.GroupBox grpWrite;
        private System.Windows.Forms.Label lblWriteTagName;
        private System.Windows.Forms.TextBox txtWriteTagName;
        private System.Windows.Forms.Label lblWriteStartIndex;
        private System.Windows.Forms.NumericUpDown nudWriteStartIndex;
        private System.Windows.Forms.Label lblWriteValues;
        private System.Windows.Forms.TextBox txtWriteValues;
        private System.Windows.Forms.Button btnWrite;

        // Read controls
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.Label lblReadTagName;
        private System.Windows.Forms.TextBox txtReadTagName;
        private System.Windows.Forms.Label lblReadStartIndex;
        private System.Windows.Forms.NumericUpDown nudReadStartIndex;
        private System.Windows.Forms.Label lblReadCount;
        private System.Windows.Forms.NumericUpDown nudReadCount;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colDecimal;
        private System.Windows.Forms.ColumnHeader colHex;

        // Log controls
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClearLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpWrite = new System.Windows.Forms.GroupBox();
            this.lblWriteTagName = new System.Windows.Forms.Label();
            this.txtWriteTagName = new System.Windows.Forms.TextBox();
            this.lblWriteStartIndex = new System.Windows.Forms.Label();
            this.nudWriteStartIndex = new System.Windows.Forms.NumericUpDown();
            this.lblWriteValues = new System.Windows.Forms.Label();
            this.txtWriteValues = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.lblReadTagName = new System.Windows.Forms.Label();
            this.txtReadTagName = new System.Windows.Forms.TextBox();
            this.lblReadStartIndex = new System.Windows.Forms.Label();
            this.nudReadStartIndex = new System.Windows.Forms.NumericUpDown();
            this.lblReadCount = new System.Windows.Forms.Label();
            this.nudReadCount = new System.Windows.Forms.NumericUpDown();
            this.btnRead = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDecimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblModbusWriteAddress = new System.Windows.Forms.Label();
            this.lblModbusReadAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.grpWrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriteStartIndex)).BeginInit();
            this.grpRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadStartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadCount)).BeginInit();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.lblIP);
            this.grpConnection.Controls.Add(this.txtIPAddress);
            this.grpConnection.Controls.Add(this.lblPort);
            this.grpConnection.Controls.Add(this.nudPort);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.lblStatusLabel);
            this.grpConnection.Controls.Add(this.lblStatus);
            this.grpConnection.Location = new System.Drawing.Point(12, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(660, 70);
            this.grpConnection.TabIndex = 0;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(10, 28);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(61, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP Address:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(85, 25);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(130, 20);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.Text = "192.168.0.250";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(225, 28);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(260, 25);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(80, 20);
            this.nudPort.TabIndex = 3;
            this.nudPort.Value = new decimal(new int[] {
            44818,
            0,
            0,
            0});
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightGreen;
            this.btnConnect.Location = new System.Drawing.Point(355, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 27);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(460, 29);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lblStatusLabel.TabIndex = 5;
            this.lblStatusLabel.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(505, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Disconnected";
            // 
            // grpWrite
            // 
            this.grpWrite.Controls.Add(this.label1);
            this.grpWrite.Controls.Add(this.lblModbusWriteAddress);
            this.grpWrite.Controls.Add(this.lblWriteTagName);
            this.grpWrite.Controls.Add(this.txtWriteTagName);
            this.grpWrite.Controls.Add(this.lblWriteStartIndex);
            this.grpWrite.Controls.Add(this.nudWriteStartIndex);
            this.grpWrite.Controls.Add(this.lblWriteValues);
            this.grpWrite.Controls.Add(this.txtWriteValues);
            this.grpWrite.Controls.Add(this.btnWrite);
            this.grpWrite.Location = new System.Drawing.Point(12, 95);
            this.grpWrite.Name = "grpWrite";
            this.grpWrite.Size = new System.Drawing.Size(660, 128);
            this.grpWrite.TabIndex = 1;
            this.grpWrite.TabStop = false;
            this.grpWrite.Text = "Write Registers";
            // 
            // lblWriteTagName
            // 
            this.lblWriteTagName.AutoSize = true;
            this.lblWriteTagName.Location = new System.Drawing.Point(10, 28);
            this.lblWriteTagName.Name = "lblWriteTagName";
            this.lblWriteTagName.Size = new System.Drawing.Size(60, 13);
            this.lblWriteTagName.TabIndex = 0;
            this.lblWriteTagName.Text = "Tag Name:";
            // 
            // txtWriteTagName
            // 
            this.txtWriteTagName.Location = new System.Drawing.Point(85, 25);
            this.txtWriteTagName.Name = "txtWriteTagName";
            this.txtWriteTagName.Size = new System.Drawing.Size(130, 20);
            this.txtWriteTagName.TabIndex = 1;
            this.txtWriteTagName.Text = "INT_DATA";
            // 
            // lblWriteStartIndex
            // 
            this.lblWriteStartIndex.AutoSize = true;
            this.lblWriteStartIndex.Location = new System.Drawing.Point(240, 28);
            this.lblWriteStartIndex.Name = "lblWriteStartIndex";
            this.lblWriteStartIndex.Size = new System.Drawing.Size(61, 13);
            this.lblWriteStartIndex.TabIndex = 2;
            this.lblWriteStartIndex.Text = "Start Index:";
            // 
            // nudWriteStartIndex
            // 
            this.nudWriteStartIndex.Location = new System.Drawing.Point(320, 25);
            this.nudWriteStartIndex.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudWriteStartIndex.Name = "nudWriteStartIndex";
            this.nudWriteStartIndex.Size = new System.Drawing.Size(80, 20);
            this.nudWriteStartIndex.TabIndex = 3;
            this.nudWriteStartIndex.Value = new decimal(new int[] {
            2260,
            0,
            0,
            0});
            this.nudWriteStartIndex.ValueChanged += new System.EventHandler(this.nudWriteStartIndex_ValueChanged);
            // 
            // lblWriteValues
            // 
            this.lblWriteValues.AutoSize = true;
            this.lblWriteValues.Location = new System.Drawing.Point(10, 60);
            this.lblWriteValues.Name = "lblWriteValues";
            this.lblWriteValues.Size = new System.Drawing.Size(135, 13);
            this.lblWriteValues.TabIndex = 4;
            this.lblWriteValues.Text = "Values (comma-separated):";
            // 
            // txtWriteValues
            // 
            this.txtWriteValues.Location = new System.Drawing.Point(10, 80);
            this.txtWriteValues.Name = "txtWriteValues";
            this.txtWriteValues.Size = new System.Drawing.Size(540, 20);
            this.txtWriteValues.TabIndex = 5;
            this.txtWriteValues.Text = "1, 2, 3, 4, 5";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.LightBlue;
            this.btnWrite.Location = new System.Drawing.Point(560, 78);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(85, 27);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.label2);
            this.grpRead.Controls.Add(this.lblModbusReadAddress);
            this.grpRead.Controls.Add(this.lblReadTagName);
            this.grpRead.Controls.Add(this.txtReadTagName);
            this.grpRead.Controls.Add(this.lblReadStartIndex);
            this.grpRead.Controls.Add(this.nudReadStartIndex);
            this.grpRead.Controls.Add(this.lblReadCount);
            this.grpRead.Controls.Add(this.nudReadCount);
            this.grpRead.Controls.Add(this.btnRead);
            this.grpRead.Controls.Add(this.listViewResults);
            this.grpRead.Location = new System.Drawing.Point(12, 229);
            this.grpRead.Name = "grpRead";
            this.grpRead.Size = new System.Drawing.Size(660, 316);
            this.grpRead.TabIndex = 2;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "Read Registers";
            // 
            // lblReadTagName
            // 
            this.lblReadTagName.AutoSize = true;
            this.lblReadTagName.Location = new System.Drawing.Point(10, 28);
            this.lblReadTagName.Name = "lblReadTagName";
            this.lblReadTagName.Size = new System.Drawing.Size(60, 13);
            this.lblReadTagName.TabIndex = 0;
            this.lblReadTagName.Text = "Tag Name:";
            // 
            // txtReadTagName
            // 
            this.txtReadTagName.Location = new System.Drawing.Point(76, 25);
            this.txtReadTagName.Name = "txtReadTagName";
            this.txtReadTagName.Size = new System.Drawing.Size(115, 20);
            this.txtReadTagName.TabIndex = 1;
            this.txtReadTagName.Text = "INT_DATA";
            // 
            // lblReadStartIndex
            // 
            this.lblReadStartIndex.AutoSize = true;
            this.lblReadStartIndex.Location = new System.Drawing.Point(214, 28);
            this.lblReadStartIndex.Name = "lblReadStartIndex";
            this.lblReadStartIndex.Size = new System.Drawing.Size(61, 13);
            this.lblReadStartIndex.TabIndex = 2;
            this.lblReadStartIndex.Text = "Start Index:";
            // 
            // nudReadStartIndex
            // 
            this.nudReadStartIndex.Location = new System.Drawing.Point(281, 26);
            this.nudReadStartIndex.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudReadStartIndex.Name = "nudReadStartIndex";
            this.nudReadStartIndex.Size = new System.Drawing.Size(80, 20);
            this.nudReadStartIndex.TabIndex = 3;
            this.nudReadStartIndex.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudReadStartIndex.ValueChanged += new System.EventHandler(this.nudReadStartIndex_ValueChanged);
            // 
            // lblReadCount
            // 
            this.lblReadCount.AutoSize = true;
            this.lblReadCount.Location = new System.Drawing.Point(449, 28);
            this.lblReadCount.Name = "lblReadCount";
            this.lblReadCount.Size = new System.Drawing.Size(38, 13);
            this.lblReadCount.TabIndex = 4;
            this.lblReadCount.Text = "Count:";
            // 
            // nudReadCount
            // 
            this.nudReadCount.Location = new System.Drawing.Point(493, 25);
            this.nudReadCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudReadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReadCount.Name = "nudReadCount";
            this.nudReadCount.Size = new System.Drawing.Size(47, 20);
            this.nudReadCount.TabIndex = 5;
            this.nudReadCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.LightYellow;
            this.btnRead.Location = new System.Drawing.Point(560, 23);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(85, 27);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colDecimal,
            this.colHex});
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(10, 95);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(635, 205);
            this.listViewResults.TabIndex = 7;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "Index";
            this.colIndex.Width = 100;
            // 
            // colDecimal
            // 
            this.colDecimal.Text = "Value (Dec)";
            this.colDecimal.Width = 200;
            // 
            // colHex
            // 
            this.colHex.Text = "Value (Hex)";
            this.colHex.Width = 200;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Controls.Add(this.btnClearLog);
            this.grpLog.Location = new System.Drawing.Point(12, 560);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(660, 170);
            this.grpLog.TabIndex = 3;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.txtLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtLog.Location = new System.Drawing.Point(10, 20);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(540, 135);
            this.txtLog.TabIndex = 0;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(560, 20);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(85, 27);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lblModbusWriteAddress
            // 
            this.lblModbusWriteAddress.AutoSize = true;
            this.lblModbusWriteAddress.Location = new System.Drawing.Point(406, 28);
            this.lblModbusWriteAddress.Name = "lblModbusWriteAddress";
            this.lblModbusWriteAddress.Size = new System.Drawing.Size(43, 13);
            this.lblModbusWriteAddress.TabIndex = 7;
            this.lblModbusWriteAddress.Text = "(41011)";
            // 
            // lblModbusReadAddress
            // 
            this.lblModbusReadAddress.AutoSize = true;
            this.lblModbusReadAddress.Location = new System.Drawing.Point(367, 30);
            this.lblModbusReadAddress.Name = "lblModbusReadAddress";
            this.lblModbusReadAddress.Size = new System.Drawing.Size(43, 13);
            this.lblModbusReadAddress.TabIndex = 8;
            this.lblModbusReadAddress.Text = "(40001)";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(524, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Write Register Range:\r\nEIP 2250 - 2497\r\n(MB 41001 - 41248)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(171, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Read Register Range: EIP 250 - 414   (MB 40001 - 40535)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(684, 741);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.grpWrite);
            this.Controls.Add(this.grpRead);
            this.Controls.Add(this.grpLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 780);
            this.Name = "Form1";
            this.Text = "EEIP Tag Read/Write Utility";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.grpWrite.ResumeLayout(false);
            this.grpWrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriteStartIndex)).EndInit();
            this.grpRead.ResumeLayout(false);
            this.grpRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadStartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadCount)).EndInit();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblModbusWriteAddress;
        private System.Windows.Forms.Label lblModbusReadAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}