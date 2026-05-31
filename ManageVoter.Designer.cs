namespace Election_Management_System
{
    partial class magangeVoter
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
            lblStatus = new Label();
            label10 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            btnDele = new Button();
            btnAdd = new Button();
            cmbAge = new ComboBox();
            cmbGen = new ComboBox();
            txtBoxN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtCnic = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtBoxCon = new TextBox();
            txtBoxPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Navy;
            lblStatus.Location = new Point(548, 705);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(196, 38);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "Total Voters : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(65, 345);
            label10.Name = "label10";
            label10.Size = new Size(153, 38);
            label10.TabIndex = 23;
            label10.Text = "Voters List";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(84, 386);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1101, 291);
            dataGridView2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(407, 74);
            label3.Name = "label3";
            label3.Size = new Size(245, 45);
            label3.TabIndex = 26;
            label3.Text = "Manage Voters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 9);
            label2.Name = "label2";
            label2.Size = new Size(1022, 54);
            label2.TabIndex = 25;
            label2.Text = "               Online Election Management System             ";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Navy;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(737, 298);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 49);
            btnClose.TabIndex = 35;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDele
            // 
            btnDele.BackColor = Color.Navy;
            btnDele.FlatAppearance.BorderSize = 3;
            btnDele.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDele.FlatStyle = FlatStyle.Flat;
            btnDele.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDele.ForeColor = Color.White;
            btnDele.Location = new Point(582, 298);
            btnDele.Name = "btnDele";
            btnDele.Size = new Size(125, 49);
            btnDele.TabIndex = 34;
            btnDele.Text = "Delete";
            btnDele.UseVisualStyleBackColor = false;
            btnDele.Click += btnDele_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(407, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 49);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbAge
            // 
            cmbAge.FormattingEnabled = true;
            cmbAge.Location = new Point(1031, 217);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(100, 33);
            cmbAge.TabIndex = 32;
            // 
            // cmbGen
            // 
            cmbGen.FormattingEnabled = true;
            cmbGen.Location = new Point(1170, 219);
            cmbGen.Name = "cmbGen";
            cmbGen.Size = new Size(102, 33);
            cmbGen.TabIndex = 31;
            // 
            // txtBoxN
            // 
            txtBoxN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxN.Location = new Point(36, 196);
            txtBoxN.Multiline = true;
            txtBoxN.Name = "txtBoxN";
            txtBoxN.Size = new Size(205, 54);
            txtBoxN.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(1170, 167);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 29;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(1031, 167);
            label5.Name = "label5";
            label5.Size = new Size(59, 32);
            label5.TabIndex = 28;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(36, 152);
            label4.Name = "label4";
            label4.Size = new Size(81, 32);
            label4.TabIndex = 27;
            label4.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(278, 152);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 36;
            label1.Text = "CNIC";
            // 
            // txtCnic
            // 
            txtCnic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCnic.Location = new Point(278, 198);
            txtCnic.Multiline = true;
            txtCnic.Name = "txtCnic";
            txtCnic.Size = new Size(205, 54);
            txtCnic.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(781, 152);
            label7.Name = "label7";
            label7.Size = new Size(122, 32);
            label7.TabIndex = 38;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(548, 152);
            label8.Name = "label8";
            label8.Size = new Size(102, 32);
            label8.TabIndex = 39;
            label8.Text = "Contact";
            // 
            // txtBoxCon
            // 
            txtBoxCon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCon.Location = new Point(535, 198);
            txtBoxCon.Multiline = true;
            txtBoxCon.Name = "txtBoxCon";
            txtBoxCon.Size = new Size(205, 54);
            txtBoxCon.TabIndex = 40;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.Location = new Point(781, 196);
            txtBoxPass.Multiline = true;
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(205, 54);
            txtBoxPass.TabIndex = 41;
            // 
            // magangeVoter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1333, 752);
            Controls.Add(txtBoxPass);
            Controls.Add(txtBoxCon);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCnic);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnDele);
            Controls.Add(btnAdd);
            Controls.Add(cmbAge);
            Controls.Add(cmbGen);
            Controls.Add(txtBoxN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(label10);
            Controls.Add(dataGridView2);
            Name = "magangeVoter";
            Text = "magangeVoter";
            Load += magangeVoter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label label10;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private Button btnDele;
        private Button btnAdd;
        private ComboBox cmbAge;
        private ComboBox cmbGen;
        private TextBox txtBoxN;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtCnic;
        private Label label7;
        private Label label8;
        private TextBox txtBoxCon;
        private TextBox txtBoxPass;
    }
}