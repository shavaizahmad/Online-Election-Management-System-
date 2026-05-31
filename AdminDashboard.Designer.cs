namespace Election_Management_System
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            label1 = new Label();
            label2 = new Label();
            btnHome = new Button();
            btnCandi = new Button();
            btnVoter = new Button();
            btnResult = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(1048, 65);
            label1.TabIndex = 0;
            label1.Text = "        Online Election Management system       ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(377, 87);
            label2.Name = "label2";
            label2.Size = new Size(377, 45);
            label2.TabIndex = 1;
            label2.Text = "Welcome Administrator";
            label2.Click += label2_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.MediumVioletRed;
            btnHome.Image = Properties.Resources.WhatsApp_Image_2026_05_09_at_10_12_02_AM;
            btnHome.Location = new Point(64, 519);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(156, 143);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnCandi
            // 
            btnCandi.BackgroundImageLayout = ImageLayout.Stretch;
            btnCandi.FlatStyle = FlatStyle.Popup;
            btnCandi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCandi.Image = (Image)resources.GetObject("btnCandi.Image");
            btnCandi.Location = new Point(303, 519);
            btnCandi.Name = "btnCandi";
            btnCandi.Size = new Size(155, 143);
            btnCandi.TabIndex = 4;
            btnCandi.UseVisualStyleBackColor = true;
            btnCandi.Click += btnCandi_Click;
            // 
            // btnVoter
            // 
            btnVoter.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_09_at_10_34_59_AM__1_;
            btnVoter.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoter.Location = new Point(598, 517);
            btnVoter.Name = "btnVoter";
            btnVoter.Size = new Size(156, 143);
            btnVoter.TabIndex = 5;
            btnVoter.UseVisualStyleBackColor = true;
            btnVoter.Click += btnVoter_Click;
            // 
            // btnResult
            // 
            btnResult.BackgroundImage = (Image)resources.GetObject("btnResult.BackgroundImage");
            btnResult.BackgroundImageLayout = ImageLayout.Stretch;
            btnResult.FlatAppearance.BorderSize = 0;
            btnResult.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.Image = (Image)resources.GetObject("btnResult.Image");
            btnResult.Location = new Point(871, 517);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(163, 143);
            btnResult.TabIndex = 6;
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 665);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 7;
            label3.Text = "DashBoard  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 667);
            label4.Name = "label4";
            label4.Size = new Size(219, 30);
            label4.TabIndex = 8;
            label4.Text = "Manage Candidates";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(598, 665);
            label5.Name = "label5";
            label5.Size = new Size(170, 30);
            label5.TabIndex = 9;
            label5.Text = "Manage Voters";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(929, 663);
            label6.Name = "label6";
            label6.Size = new Size(84, 32);
            label6.TabIndex = 10;
            label6.Text = "Result";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1019, 689);
            button1.Name = "button1";
            button1.Size = new Size(132, 47);
            button1.TabIndex = 11;
            button1.Text = "Back->";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 748);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnResult);
            Controls.Add(btnVoter);
            Controls.Add(btnCandi);
            Controls.Add(btnHome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnHome;
        private Button btnCandi;
        private Button btnVoter;
        private Button btnResult;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}