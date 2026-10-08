namespace design
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dgvUserDetails = new DataGridView();
            panel4 = new Panel();
            btndelete = new Button();
            btnedit = new Button();
            label3 = new Label();
            txtemail = new TextBox();
            lblid = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnclear = new Button();
            btnadd = new Button();
            radother = new RadioButton();
            radfemale = new RadioButton();
            radmale = new RadioButton();
            comboBox1 = new ComboBox();
            txtcontact = new TextBox();
            txtname = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserDetails).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 508);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 413);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvUserDetails);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(367, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(433, 413);
            panel5.TabIndex = 1;
            // 
            // dgvUserDetails
            // 
            dgvUserDetails.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvUserDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserDetails.Dock = DockStyle.Fill;
            dgvUserDetails.Location = new Point(0, 0);
            dgvUserDetails.Name = "dgvUserDetails";
            dgvUserDetails.RowHeadersWidth = 51;
            dgvUserDetails.Size = new Size(433, 413);
            dgvUserDetails.TabIndex = 0;
            dgvUserDetails.CellClick += dgvUserDetails_CellClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 255);
            panel4.Controls.Add(btndelete);
            panel4.Controls.Add(btnedit);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtemail);
            panel4.Controls.Add(lblid);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnclear);
            panel4.Controls.Add(btnadd);
            panel4.Controls.Add(radother);
            panel4.Controls.Add(radfemale);
            panel4.Controls.Add(radmale);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(txtcontact);
            panel4.Controls.Add(txtname);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(367, 413);
            panel4.TabIndex = 0;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(12, 357);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 18;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(134, 295);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 29);
            btnedit.TabIndex = 1;
            btnedit.Text = "Update";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 120);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(104, 113);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(166, 27);
            txtemail.TabIndex = 16;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.Location = new Point(101, 29);
            lblid.Name = "lblid";
            lblid.Size = new Size(29, 20);
            lblid.TabIndex = 15;
            lblid.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 78);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 14;
            label7.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 153);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 13;
            label6.Text = "ContactNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 192);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 12;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 244);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 11;
            label4.Text = "Country";
            // 
            // btnclear
            // 
            btnclear.Location = new Point(134, 357);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 9;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(11, 295);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 0;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // radother
            // 
            radother.AutoSize = true;
            radother.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radother.Location = new Point(283, 188);
            radother.Name = "radother";
            radother.Size = new Size(81, 24);
            radother.TabIndex = 8;
            radother.TabStop = true;
            radother.Text = "gay/les";
            radother.UseVisualStyleBackColor = true;
            // 
            // radfemale
            // 
            radfemale.AutoSize = true;
            radfemale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radfemale.Location = new Point(189, 188);
            radfemale.Name = "radfemale";
            radfemale.Size = new Size(78, 24);
            radfemale.TabIndex = 7;
            radfemale.TabStop = true;
            radfemale.Text = "female";
            radfemale.UseVisualStyleBackColor = true;
            // 
            // radmale
            // 
            radmale.AutoSize = true;
            radmale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radmale.Location = new Point(101, 188);
            radmale.Name = "radmale";
            radmale.Size = new Size(64, 24);
            radmale.TabIndex = 6;
            radmale.TabStop = true;
            radmale.Text = "male";
            radmale.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 28);
            comboBox1.TabIndex = 5;
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(104, 150);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(166, 27);
            txtcontact.TabIndex = 4;
            // 
            // txtname
            // 
            txtname.Location = new Point(104, 78);
            txtname.Name = "txtname";
            txtname.Size = new Size(166, 27);
            txtname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 29);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 95);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 21);
            label1.Name = "label1";
            label1.Size = new Size(407, 35);
            label1.TabIndex = 0;
            label1.Text = "Welcome mero sathi haru";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += UserInfo_load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserDetails).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private RadioButton radother;
        private RadioButton radfemale;
        private RadioButton radmale;
        private ComboBox comboBox1;
        private TextBox txtcontact;
        private TextBox txtname;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnclear;
        private Button btnadd;
        private DataGridView dgvUserDetails;
        private Label lblid;
        private TextBox txtemail;
        private Label label3;
        private Button btnedit;
        private Button btndelete;
    }
}