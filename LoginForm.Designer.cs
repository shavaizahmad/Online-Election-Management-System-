namespace Election_Management_System
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblRole = new Label();
            label3 = new Label();
            lblPassword = new Label();
            lblCnic = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnSignup = new Button();
            btnLogin = new Button();
            txtBoxPass = new TextBox();
            txtBoxN = new TextBox();
            cmbRole = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(-10, -3);
            label1.Name = "label1";
            label1.Size = new Size(1134, 56);
            label1.TabIndex = 0;
            label1.Text = "                     Online Election Management System                 ";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Navy;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.WhiteSmoke;
            lblRole.Location = new Point(35, 139);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(71, 32);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Navy;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 27);
            label3.Name = "label3";
            label3.Size = new Size(311, 45);
            label3.TabIndex = 2;
            label3.Tag = "    ";
            label3.Text = "        Welcome         ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Navy;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.LavenderBlush;
            lblPassword.Location = new Point(35, 280);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 32);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblCnic
            // 
            lblCnic.AutoSize = true;
            lblCnic.BackColor = Color.Navy;
            lblCnic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCnic.ForeColor = Color.LavenderBlush;
            lblCnic.Location = new Point(35, 202);
            lblCnic.Name = "lblCnic";
            lblCnic.Size = new Size(129, 32);
            lblCnic.TabIndex = 4;
            lblCnic.Text = "User CNIC";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSignup);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtBoxPass);
            groupBox1.Controls.Add(txtBoxN);
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblCnic);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.LemonChiffon;
            groupBox1.Location = new Point(634, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 497);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(146, 86);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 10;
            label2.Text = "Login YourSelf";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Navy;
            btnSignup.FlatAppearance.MouseOverBackColor = Color.Brown;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.Location = new Point(283, 390);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(145, 58);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "SignUP";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Brown;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(76, 390);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 58);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPass.Location = new Point(187, 264);
            txtBoxPass.MaxLength = 6;
            txtBoxPass.Multiline = true;
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.PasswordChar = '3';
            txtBoxPass.PlaceholderText = " Enter Correct Password";
            txtBoxPass.Size = new Size(251, 48);
            txtBoxPass.TabIndex = 7;
            txtBoxPass.UseSystemPasswordChar = true;
            // 
            // txtBoxN
            // 
            txtBoxN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxN.Location = new Point(187, 188);
            txtBoxN.MaxLength = 11;
            txtBoxN.Multiline = true;
            txtBoxN.Name = "txtBoxN";
            txtBoxN.PlaceholderText = "   Enter Correct CNIC";
            txtBoxN.Size = new Size(251, 46);
            txtBoxN.TabIndex = 6;
            // 
            // cmbRole
            // 
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(187, 138);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(182, 33);
            cmbRole.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 1500;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(298, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 226);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_23_at_9_05_02_PM;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(76, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 56);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(174, 93);
            label5.Name = "label5";
            label5.Size = new Size(255, 38);
            label5.TabIndex = 2;
            label5.Text = "Login Successfully";
            label5.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(493, 66);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(334, 16);
            label6.Name = "label6";
            label6.Size = new Size(142, 30);
            label6.TabIndex = 3;
            label6.Text = "Best Of Luck";
            label6.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 50);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(30, 11);
            label4.Name = "label4";
            label4.Size = new Size(108, 30);
            label4.TabIndex = 0;
            label4.Text = "Welcome";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 666);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.Lavender;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblRole;
        private Label label3;
        private Label lblPassword;
        private Label lblCnic;
        private GroupBox groupBox1;
        private TextBox txtBoxPass;
        private TextBox txtBoxN;
        private ComboBox cmbRole;
        private Button btnSignup;
        private Button btnLogin;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
