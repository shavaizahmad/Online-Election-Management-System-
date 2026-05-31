namespace Election_Management_System
{
    partial class SignupForm
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
            txtBoxn = new TextBox();
            txtBoxCnic = new TextBox();
            TxtBoxNo = new TextBox();
            txtBoxPass = new TextBox();
            btnsignup = new Button();
            btnBack = new Button();
            label6 = new Label();
            label7 = new Label();
            cmbAge = new ComboBox();
            label8 = new Label();
            cmbGen = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(578, 9);
            label1.Name = "label1";
            label1.Size = new Size(447, 65);
            label1.TabIndex = 1;
            label1.Text = "          Register        ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(578, 156);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(578, 227);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 3;
            label3.Text = "User CNIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(585, 297);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 4;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(585, 378);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // txtBoxn
            // 
            txtBoxn.Location = new Point(752, 144);
            txtBoxn.Multiline = true;
            txtBoxn.Name = "txtBoxn";
            txtBoxn.PlaceholderText = "         Enter Correct Name";
            txtBoxn.Size = new Size(282, 44);
            txtBoxn.TabIndex = 6;
            // 
            // txtBoxCnic
            // 
            txtBoxCnic.Location = new Point(752, 213);
            txtBoxCnic.MaxLength = 11;
            txtBoxCnic.Multiline = true;
            txtBoxCnic.Name = "txtBoxCnic";
            txtBoxCnic.PlaceholderText = "     Enter Cnic (without Dashes)";
            txtBoxCnic.Size = new Size(282, 46);
            txtBoxCnic.TabIndex = 7;
            // 
            // TxtBoxNo
            // 
            TxtBoxNo.Location = new Point(752, 283);
            TxtBoxNo.MaxLength = 11;
            TxtBoxNo.Multiline = true;
            TxtBoxNo.Name = "TxtBoxNo";
            TxtBoxNo.PlaceholderText = "        Enter Mobile Number";
            TxtBoxNo.Size = new Size(282, 46);
            TxtBoxNo.TabIndex = 8;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Location = new Point(752, 361);
            txtBoxPass.MaxLength = 6;
            txtBoxPass.Multiline = true;
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PlaceholderText = "         Enter Strong Password";
            txtBoxPass.Size = new Size(282, 49);
            txtBoxPass.TabIndex = 9;
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.White;
            btnsignup.FlatAppearance.MouseOverBackColor = Color.Red;
            btnsignup.FlatStyle = FlatStyle.Flat;
            btnsignup.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsignup.Location = new Point(629, 593);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(150, 60);
            btnsignup.TabIndex = 10;
            btnsignup.Text = "SignUp";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(872, 593);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 60);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(700, 83);
            label6.Name = "label6";
            label6.Size = new Size(231, 30);
            label6.TabIndex = 12;
            label6.Text = "  Create Your Profile  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(585, 449);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 13;
            label7.Text = "Gender";
            // 
            // cmbAge
            // 
            cmbAge.FormattingEnabled = true;
            cmbAge.Location = new Point(752, 512);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(282, 33);
            cmbAge.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.WhiteSmoke;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(585, 509);
            label8.Name = "label8";
            label8.Size = new Size(59, 32);
            label8.TabIndex = 34;
            label8.Text = "Age";
            // 
            // cmbGen
            // 
            cmbGen.FormattingEnabled = true;
            cmbGen.Location = new Point(752, 448);
            cmbGen.Name = "cmbGen";
            cmbGen.Size = new Size(282, 33);
            cmbGen.TabIndex = 35;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_13_at_5_50_24_PM;
            ClientSize = new Size(1046, 679);
            Controls.Add(cmbGen);
            Controls.Add(label8);
            Controls.Add(cmbAge);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnBack);
            Controls.Add(btnsignup);
            Controls.Add(txtBoxPass);
            Controls.Add(TxtBoxNo);
            Controls.Add(txtBoxCnic);
            Controls.Add(txtBoxn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "SignupForm";
            Text = "SignupForm";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxn;
        private TextBox txtBoxCnic;
        private TextBox TxtBoxNo;
        private TextBox txtBoxPass;
        private Button btnsignup;
        private Button btnBack;
        private Label label6;
        private Label label7;
        private ComboBox cmbAge;
        private Label label8;
        private ComboBox cmbGen;
    }
}