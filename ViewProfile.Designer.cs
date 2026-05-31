namespace Election_Management_System
{
    partial class ViewProfile
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
            label2 = new Label();
            lblWel = new Label();
            lblN = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblPass = new Label();
            lblNo = new Label();
            lblAge = new Label();
            lblGen = new Label();
            lblCnic = new Label();
            label5 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(1022, 54);
            label2.TabIndex = 26;
            label2.Text = "               Online Election Management System             ";
            // 
            // lblWel
            // 
            lblWel.AutoSize = true;
            lblWel.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWel.Location = new Point(353, 81);
            lblWel.Name = "lblWel";
            lblWel.Size = new Size(189, 43);
            lblWel.TabIndex = 27;
            lblWel.Text = "Welcome";
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.BackColor = Color.MidnightBlue;
            lblN.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblN.ForeColor = SystemColors.ButtonHighlight;
            lblN.Location = new Point(155, 109);
            lblN.Name = "lblN";
            lblN.Size = new Size(89, 37);
            lblN.TabIndex = 28;
            lblN.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 232);
            label1.Name = "label1";
            label1.Size = new Size(0, 42);
            label1.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblNo);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(lblGen);
            panel1.Controls.Add(lblCnic);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblN);
            panel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(81, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 308);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.ForeColor = SystemColors.ButtonHighlight;
            lblPass.Location = new Point(564, 237);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(139, 38);
            lblPass.TabIndex = 37;
            lblPass.Text = "Password";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNo.ForeColor = SystemColors.ButtonHighlight;
            lblNo.Location = new Point(564, 176);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(118, 38);
            lblNo.TabIndex = 36;
            lblNo.Text = "Contact";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = SystemColors.ButtonHighlight;
            lblAge.Location = new Point(155, 237);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(69, 38);
            lblAge.TabIndex = 35;
            lblAge.Text = "Age";
            // 
            // lblGen
            // 
            lblGen.AutoSize = true;
            lblGen.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGen.ForeColor = SystemColors.ButtonHighlight;
            lblGen.Location = new Point(564, 108);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(112, 38);
            lblGen.TabIndex = 34;
            lblGen.Text = "Gender";
            // 
            // lblCnic
            // 
            lblCnic.AutoSize = true;
            lblCnic.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCnic.ForeColor = SystemColors.ButtonHighlight;
            lblCnic.Location = new Point(155, 176);
            lblCnic.Name = "lblCnic";
            lblCnic.Size = new Size(90, 38);
            lblCnic.TabIndex = 33;
            lblCnic.Text = "CNIC ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(336, 0);
            label5.Name = "label5";
            label5.Size = new Size(203, 48);
            label5.TabIndex = 32;
            label5.Text = "My Profile ";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(429, 464);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(234, 58);
            btnBack.TabIndex = 33;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ViewProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1038, 543);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblWel);
            Controls.Add(label2);
            Name = "ViewProfile";
            Text = "ViewProfile";
            Load += ViewProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblWel;
        private Label lblN;
        private Label label1;
        private Panel panel1;
        private Label lblNo;
        private Label lblAge;
        private Label lblGen;
        private Label lblCnic;
        private Label label5;
        private Label lblPass;
        private Button btnBack;
    }
}