namespace Election_Management_System
{
    partial class EditVoter
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
            txtBoxPass = new TextBox();
            txtBoxCon = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtCnic = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            cmbAge = new ComboBox();
            cmbGen = new ComboBox();
            txtBoxN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBoxPass
            // 
            txtBoxPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.Location = new Point(384, 359);
            txtBoxPass.Multiline = true;
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(205, 54);
            txtBoxPass.TabIndex = 57;
            // 
            // txtBoxCon
            // 
            txtBoxCon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCon.Location = new Point(70, 369);
            txtBoxCon.Multiline = true;
            txtBoxCon.Name = "txtBoxCon";
            txtBoxCon.Size = new Size(205, 54);
            txtBoxCon.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(70, 334);
            label8.Name = "label8";
            label8.Size = new Size(102, 32);
            label8.TabIndex = 55;
            label8.Text = "Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(384, 324);
            label7.Name = "label7";
            label7.Size = new Size(122, 32);
            label7.TabIndex = 54;
            label7.Text = "Password";
            // 
            // txtCnic
            // 
            txtCnic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCnic.Location = new Point(384, 238);
            txtCnic.Multiline = true;
            txtCnic.Name = "txtCnic";
            txtCnic.Size = new Size(205, 54);
            txtCnic.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(384, 203);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 52;
            label1.Text = "CNIC";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Navy;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(339, 575);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 49);
            btnClose.TabIndex = 51;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(171, 575);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 49);
            btnAdd.TabIndex = 50;
            btnAdd.Text = "Update";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbAge
            // 
            cmbAge.FormattingEnabled = true;
            cmbAge.Location = new Point(70, 482);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(205, 33);
            cmbAge.TabIndex = 49;
            // 
            // cmbGen
            // 
            cmbGen.FormattingEnabled = true;
            cmbGen.Location = new Point(384, 482);
            cmbGen.Name = "cmbGen";
            cmbGen.Size = new Size(205, 33);
            cmbGen.TabIndex = 48;
            // 
            // txtBoxN
            // 
            txtBoxN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxN.Location = new Point(70, 238);
            txtBoxN.Multiline = true;
            txtBoxN.Name = "txtBoxN";
            txtBoxN.Size = new Size(205, 54);
            txtBoxN.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(384, 451);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 46;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(70, 447);
            label5.Name = "label5";
            label5.Size = new Size(59, 32);
            label5.TabIndex = 45;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(70, 203);
            label4.Name = "label4";
            label4.Size = new Size(81, 32);
            label4.TabIndex = 44;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(160, 107);
            label3.Name = "label3";
            label3.Size = new Size(328, 45);
            label3.TabIndex = 43;
            label3.Text = "Update Voter Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-1, 20);
            label2.Name = "label2";
            label2.Size = new Size(646, 48);
            label2.TabIndex = 42;
            label2.Text = "Online Election Management System ";
            // 
            // EditVoter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(665, 697);
            Controls.Add(txtBoxPass);
            Controls.Add(txtBoxCon);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCnic);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(cmbAge);
            Controls.Add(cmbGen);
            Controls.Add(txtBoxN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "EditVoter";
            Text = "EditVoter";
            Load += EditVoter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPass;
        private TextBox txtBoxCon;
        private Label label8;
        private Label label7;
        private TextBox txtCnic;
        private Label label1;
        private Button btnClose;
        private Button btnAdd;
        private ComboBox cmbAge;
        private ComboBox cmbGen;
        private TextBox txtBoxN;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}