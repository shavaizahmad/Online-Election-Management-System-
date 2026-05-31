namespace Election_Management_System
{
    partial class EditProfile
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
            panel1 = new Panel();
            txtBoxNew = new TextBox();
            txtBoxOld = new TextBox();
            panel2 = new Panel();
            txtBoxNP = new TextBox();
            txtBoxP = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 28);
            label1.Name = "label1";
            label1.Size = new Size(371, 43);
            label1.TabIndex = 0;
            label1.Text = "Edit Your Profile";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 21);
            label2.Name = "label2";
            label2.Size = new Size(138, 26);
            label2.TabIndex = 1;
            label2.Text = "Old Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(148, 26);
            label3.TabIndex = 2;
            label3.Text = "New Contact";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(txtBoxNew);
            panel1.Controls.Add(txtBoxOld);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(61, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 144);
            panel1.TabIndex = 5;
            // 
            // txtBoxNew
            // 
            txtBoxNew.Location = new Point(188, 85);
            txtBoxNew.Name = "txtBoxNew";
            txtBoxNew.Size = new Size(211, 31);
            txtBoxNew.TabIndex = 4;
            // 
            // txtBoxOld
            // 
            txtBoxOld.Location = new Point(188, 21);
            txtBoxOld.Name = "txtBoxOld";
            txtBoxOld.Size = new Size(211, 31);
            txtBoxOld.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Violet;
            panel2.Controls.Add(txtBoxNP);
            panel2.Controls.Add(txtBoxP);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(61, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 141);
            panel2.TabIndex = 6;
            // 
            // txtBoxNP
            // 
            txtBoxNP.Location = new Point(188, 85);
            txtBoxNP.Name = "txtBoxNP";
            txtBoxNP.Size = new Size(211, 31);
            txtBoxNP.TabIndex = 6;
            // 
            // txtBoxP
            // 
            txtBoxP.Location = new Point(188, 19);
            txtBoxP.Name = "txtBoxP";
            txtBoxP.Size = new Size(211, 31);
            txtBoxP.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 21);
            label6.Name = "label6";
            label6.Size = new Size(160, 26);
            label6.TabIndex = 1;
            label6.Text = "Old Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 90);
            label7.Name = "label7";
            label7.Size = new Size(170, 26);
            label7.TabIndex = 2;
            label7.Text = "New Password";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(155, 499);
            button1.Name = "button1";
            button1.Size = new Size(129, 45);
            button1.TabIndex = 7;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumBlue;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(322, 472);
            button2.Name = "button2";
            button2.Size = new Size(129, 45);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(576, 556);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "EditProfile";
            Text = "EditProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private TextBox txtBoxNew;
        private TextBox txtBoxOld;
        private TextBox txtBoxNP;
        private TextBox txtBoxP;
        private Button button1;
        private Button button2;
    }
}