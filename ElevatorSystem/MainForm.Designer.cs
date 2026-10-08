namespace ElevatorSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFloor2 = new Label();
            lblFloor1 = new Label();
            btnRequest2 = new Button();
            btnRequest1 = new Button();
            grpControlPanel = new GroupBox();
            txtControlDisplay = new TextBox();
            LblCtrlCaption = new Label();
            btnFloor2 = new Button();
            btnFloor1 = new Button();
            grpFloorStatus = new GroupBox();
            lblStatus2 = new Label();
            lblStatusCap2 = new Label();
            LblStatus1 = new Label();
            lblStatusCap1 = new Label();
            grpLog = new GroupBox();
            dgvLog = new DataGridView();
            btnRefreshLog = new Button();
            btnClearLog = new Button();
            btnReset = new Button();
            pnlShaft = new Panel();
            picElevator = new PictureBox();
            grpControlPanel.SuspendLayout();
            grpFloorStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            pnlShaft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picElevator).BeginInit();
            SuspendLayout();
            // 
            // lblFloor2
            // 
            lblFloor2.AutoSize = true;
            lblFloor2.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFloor2.ForeColor = Color.White;
            lblFloor2.Location = new Point(12, 90);
            lblFloor2.Name = "lblFloor2";
            lblFloor2.Size = new Size(70, 20);
            lblFloor2.TabIndex = 2;
            lblFloor2.Text = "Floor 2";
            // 
            // lblFloor1
            // 
            lblFloor1.AutoSize = true;
            lblFloor1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFloor1.ForeColor = Color.White;
            lblFloor1.Location = new Point(12, 437);
            lblFloor1.Name = "lblFloor1";
            lblFloor1.Size = new Size(66, 23);
            lblFloor1.TabIndex = 3;
            lblFloor1.Text = "Floor 1";
            // 
            // btnRequest2
            // 
            btnRequest2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest2.Location = new Point(500, 60);
            btnRequest2.Name = "btnRequest2";
            btnRequest2.Size = new Size(50, 50);
            btnRequest2.TabIndex = 4;
            btnRequest2.Text = "▲";
            btnRequest2.UseVisualStyleBackColor = true;
            btnRequest2.Click += btnRequest2_Click_1;
            // 
            // btnRequest1
            // 
            btnRequest1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest1.Location = new Point(500, 420);
            btnRequest1.Name = "btnRequest1";
            btnRequest1.Size = new Size(50, 50);
            btnRequest1.TabIndex = 5;
            btnRequest1.Text = "▼";
            btnRequest1.UseVisualStyleBackColor = true;
            btnRequest1.Click += btnRequest1_Click_1;
            // 
            // grpControlPanel
            // 
            grpControlPanel.Controls.Add(txtControlDisplay);
            grpControlPanel.Controls.Add(LblCtrlCaption);
            grpControlPanel.Controls.Add(btnFloor2);
            grpControlPanel.Controls.Add(btnFloor1);
            grpControlPanel.ForeColor = Color.White;
            grpControlPanel.Location = new Point(600, 40);
            grpControlPanel.Name = "grpControlPanel";
            grpControlPanel.Size = new Size(220, 130);
            grpControlPanel.TabIndex = 6;
            grpControlPanel.TabStop = false;
            grpControlPanel.Text = "Elevator Control Panel";
            // 
            // txtControlDisplay
            // 
            txtControlDisplay.Location = new Point(100, 82);
            txtControlDisplay.Name = "txtControlDisplay";
            txtControlDisplay.ReadOnly = true;
            txtControlDisplay.Size = new Size(60, 27);
            txtControlDisplay.TabIndex = 3;
            txtControlDisplay.Text = "1";
            txtControlDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // LblCtrlCaption
            // 
            LblCtrlCaption.AutoSize = true;
            LblCtrlCaption.Location = new Point(20, 85);
            LblCtrlCaption.Name = "LblCtrlCaption";
            LblCtrlCaption.Size = new Size(57, 20);
            LblCtrlCaption.TabIndex = 2;
            LblCtrlCaption.Text = "Current";
            // 
            // btnFloor2
            // 
            btnFloor2.ForeColor = Color.Black;
            btnFloor2.Location = new Point(90, 30);
            btnFloor2.Name = "btnFloor2";
            btnFloor2.Size = new Size(50, 30);
            btnFloor2.TabIndex = 1;
            btnFloor2.Text = "2";
            btnFloor2.UseVisualStyleBackColor = true;
            btnFloor2.Click += btnFloor2_Click;
            // 
            // btnFloor1
            // 
            btnFloor1.ForeColor = Color.Black;
            btnFloor1.Location = new Point(20, 30);
            btnFloor1.Name = "btnFloor1";
            btnFloor1.Size = new Size(50, 30);
            btnFloor1.TabIndex = 0;
            btnFloor1.Text = "1";
            btnFloor1.UseVisualStyleBackColor = true;
            btnFloor1.Click += btnFloor1_Click_1;
            // 
            // grpFloorStatus
            // 
            grpFloorStatus.Controls.Add(lblStatus2);
            grpFloorStatus.Controls.Add(lblStatusCap2);
            grpFloorStatus.Controls.Add(LblStatus1);
            grpFloorStatus.Controls.Add(lblStatusCap1);
            grpFloorStatus.ForeColor = Color.White;
            grpFloorStatus.Location = new Point(600, 190);
            grpFloorStatus.Name = "grpFloorStatus";
            grpFloorStatus.Size = new Size(220, 110);
            grpFloorStatus.TabIndex = 7;
            grpFloorStatus.TabStop = false;
            grpFloorStatus.Text = "Floor Status";
            // 
            // lblStatus2
            // 
            lblStatus2.AutoSize = true;
            lblStatus2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus2.ForeColor = Color.Gray;
            lblStatus2.Location = new Point(110, 60);
            lblStatus2.Name = "lblStatus2";
            lblStatus2.Size = new Size(41, 38);
            lblStatus2.TabIndex = 3;
            lblStatus2.Text = "○";
            // 
            // lblStatusCap2
            // 
            lblStatusCap2.AutoSize = true;
            lblStatusCap2.Location = new Point(20, 65);
            lblStatusCap2.Name = "lblStatusCap2";
            lblStatusCap2.Size = new Size(58, 20);
            lblStatusCap2.TabIndex = 2;
            lblStatusCap2.Text = "Floor 2:";
            // 
            // LblStatus1
            // 
            LblStatus1.AutoSize = true;
            LblStatus1.ForeColor = Color.LimeGreen;
            LblStatus1.Location = new Point(110, 25);
            LblStatus1.Name = "LblStatus1";
            LblStatus1.Size = new Size(18, 20);
            LblStatus1.TabIndex = 1;
            LblStatus1.Text = "●";
            // 
            // lblStatusCap1
            // 
            lblStatusCap1.AutoSize = true;
            lblStatusCap1.Location = new Point(20, 30);
            lblStatusCap1.Name = "lblStatusCap1";
            lblStatusCap1.Size = new Size(55, 20);
            lblStatusCap1.TabIndex = 0;
            lblStatusCap1.Text = "Floor 1";
            // 
            // grpLog
            // 
            grpLog.ForeColor = Color.White;
            grpLog.Location = new Point(23, 548);
            grpLog.Name = "grpLog";
            grpLog.Size = new Size(620, 180);
            grpLog.TabIndex = 8;
            grpLog.TabStop = false;
            grpLog.Text = "Operation Log";
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLog.Location = new Point(600, 340);
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.RowHeadersWidth = 51;
            dgvLog.Size = new Size(590, 140);
            dgvLog.TabIndex = 9;
            // 
            // btnRefreshLog
            // 
            btnRefreshLog.Location = new Point(690, 510);
            btnRefreshLog.Name = "btnRefreshLog";
            btnRefreshLog.Size = new Size(120, 40);
            btnRefreshLog.TabIndex = 10;
            btnRefreshLog.Text = "Refresh Log";
            btnRefreshLog.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(690, 560);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(120, 40);
            btnClearLog.TabIndex = 11;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(690, 610);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 40);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // pnlShaft
            // 
            pnlShaft.BorderStyle = BorderStyle.FixedSingle;
            pnlShaft.Controls.Add(picElevator);
            pnlShaft.Location = new Point(89, 40);
            pnlShaft.Name = "pnlShaft";
            pnlShaft.Size = new Size(387, 502);
            pnlShaft.TabIndex = 13;
            // 
            // picElevator
            // 
            picElevator.BackColor = Color.Gold;
            picElevator.Location = new Point(-6, 213);
            picElevator.Name = "picElevator";
            picElevator.Size = new Size(387, 288);
            picElevator.SizeMode = PictureBoxSizeMode.StretchImage;
            picElevator.TabIndex = 0;
            picElevator.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1217, 754);
            Controls.Add(pnlShaft);
            Controls.Add(btnReset);
            Controls.Add(btnClearLog);
            Controls.Add(btnRefreshLog);
            Controls.Add(dgvLog);
            Controls.Add(grpLog);
            Controls.Add(grpFloorStatus);
            Controls.Add(grpControlPanel);
            Controls.Add(btnRequest1);
            Controls.Add(btnRequest2);
            Controls.Add(lblFloor2);
            Controls.Add(lblFloor1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cha";
            grpControlPanel.ResumeLayout(false);
            grpControlPanel.PerformLayout();
            grpFloorStatus.ResumeLayout(false);
            grpFloorStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            pnlShaft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picElevator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picElevator;
        private Label lblFloor2;
        private Label lblFloor1;
        private Button btnRequest2;
        private Button btnRequest1;
        private GroupBox grpControlPanel;
        private Button btnFloor2;
        private Button btnFloor1;
        private TextBox txtControlDisplay;
        private Label LblCtrlCaption;
        private GroupBox grpFloorStatus;
        private Label lblStatusCap1;
        private Label lblStatusCap2;
        private Label LblStatus1;
        private Label lblStatus2;
        private GroupBox grpLog;
        private DataGridView dgvLog;
        private Button btnRefreshLog;
        private Button btnClearLog;
        private Button btnReset;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel pnlShaft;
    }
}
