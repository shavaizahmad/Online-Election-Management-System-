namespace Election_Management_System
{
    partial class Candidate
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtBoxn = new TextBox();
            cmbGen = new ComboBox();
            cmbParty = new ComboBox();
            cmbSeat = new ComboBox();
            cmbAge = new ComboBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnBack = new Button();
            cmbSym = new ComboBox();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 74);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 9);
            label2.Name = "label2";
            label2.Size = new Size(1022, 54);
            label2.TabIndex = 1;
            label2.Text = "               Online Election Management System             ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(443, 74);
            label3.Name = "label3";
            label3.Size = new Size(315, 45);
            label3.TabIndex = 2;
            label3.Text = "Manage Candidates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(82, 211);
            label4.Name = "label4";
            label4.Size = new Size(81, 32);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(82, 313);
            label5.Name = "label5";
            label5.Size = new Size(59, 32);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(317, 211);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(82, 427);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 6;
            label7.Text = "Symbol";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(317, 427);
            label8.Name = "label8";
            label8.Size = new Size(63, 28);
            label8.TabIndex = 7;
            label8.Text = "Party";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(317, 313);
            label9.Name = "label9";
            label9.Size = new Size(62, 32);
            label9.TabIndex = 8;
            label9.Text = "Seat";
            label9.Click += label9_Click;
            // 
            // txtBoxn
            // 
            txtBoxn.Location = new Point(82, 246);
            txtBoxn.Multiline = true;
            txtBoxn.Name = "txtBoxn";
            txtBoxn.Size = new Size(181, 33);
            txtBoxn.TabIndex = 9;
            // 
            // cmbGen
            // 
            cmbGen.FormattingEnabled = true;
            cmbGen.Location = new Point(317, 246);
            cmbGen.Name = "cmbGen";
            cmbGen.Size = new Size(164, 33);
            cmbGen.TabIndex = 11;
            // 
            // cmbParty
            // 
            cmbParty.FormattingEnabled = true;
            cmbParty.Location = new Point(317, 458);
            cmbParty.Name = "cmbParty";
            cmbParty.Size = new Size(164, 33);
            cmbParty.TabIndex = 12;
            // 
            // cmbSeat
            // 
            cmbSeat.FormattingEnabled = true;
            cmbSeat.Location = new Point(317, 348);
            cmbSeat.Name = "cmbSeat";
            cmbSeat.Size = new Size(164, 33);
            cmbSeat.TabIndex = 13;
            // 
            // cmbAge
            // 
            cmbAge.FormattingEnabled = true;
            cmbAge.Location = new Point(82, 348);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(181, 33);
            cmbAge.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(138, 577);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 49);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Navy;
            btnDel.FlatAppearance.BorderSize = 3;
            btnDel.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(292, 577);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(125, 49);
            btnDel.TabIndex = 16;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Navy;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(221, 647);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 49);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cmbSym
            // 
            cmbSym.FormattingEnabled = true;
            cmbSym.Location = new Point(82, 458);
            cmbSym.Name = "cmbSym";
            cmbSym.Size = new Size(181, 33);
            cmbSym.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(504, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(631, 401);
            dataGridView1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(723, 183);
            label10.Name = "label10";
            label10.Size = new Size(202, 38);
            label10.TabIndex = 20;
            label10.Text = "Candidate List";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Navy;
            lblStatus.Location = new Point(705, 650);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(257, 38);
            lblStatus.TabIndex = 21;
            lblStatus.Text = "Total Candidates : ";
            // 
            // Candidate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1147, 762);
            Controls.Add(lblStatus);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(cmbSym);
            Controls.Add(btnBack);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(cmbAge);
            Controls.Add(cmbSeat);
            Controls.Add(cmbParty);
            Controls.Add(cmbGen);
            Controls.Add(txtBoxn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Candidate";
            Text = "Candidate";
            Load += Candidate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBoxn;
        private ComboBox cmbGen;
        private ComboBox cmbParty;
        private ComboBox cmbSeat;
        private ComboBox cmbAge;
        private Button btnAdd;
        private Button btnDel;
        private Button btnBack;
        private ComboBox cmbSym;
        private DataGridView dataGridView1;
        private Label label10;
        private Label lblStatus;
    }
}