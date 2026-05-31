namespace Election_Management_System
{
    partial class UserBoard
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
            Button btnView;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBoard));
            label1 = new Label();
            label2 = new Label();
            btnVote = new Button();
            btnEdit = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnView = new Button();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_09_at_3_08_05_PM__1_;
            btnView.BackgroundImageLayout = ImageLayout.Stretch;
            btnView.Location = new Point(27, 402);
            btnView.Name = "btnView";
            btnView.Size = new Size(148, 98);
            btnView.TabIndex = 3;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(978, 54);
            label1.TabIndex = 0;
            label1.Text = "             Online Election Management System           ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(357, 74);
            label2.Name = "label2";
            label2.Size = new Size(238, 45);
            label2.TabIndex = 1;
            label2.Text = "Welcome Dear";
            label2.Click += label2_Click;
            // 
            // btnVote
            // 
            btnVote.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_09_at_3_081;
            btnVote.BackgroundImageLayout = ImageLayout.Stretch;
            btnVote.FlatAppearance.BorderSize = 0;
            btnVote.FlatAppearance.MouseOverBackColor = Color.Red;
            btnVote.FlatStyle = FlatStyle.Flat;
            btnVote.Location = new Point(27, 248);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(148, 98);
            btnVote.TabIndex = 2;
            btnVote.UseVisualStyleBackColor = true;
            btnVote.Click += btnVote_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_09_at_3_082;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.Location = new Point(27, 567);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 98);
            btnEdit.TabIndex = 4;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(36, 503);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 5;
            label3.Text = "View Profile  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(39, 668);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 6;
            label4.Text = "Edit Profile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(56, 349);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 7;
            label5.Text = "Cast Vote";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(716, 668);
            button1.Name = "button1";
            button1.Size = new Size(113, 45);
            button1.TabIndex = 8;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(873, 668);
            button2.Name = "button2";
            button2.Size = new Size(113, 45);
            button2.TabIndex = 9;
            button2.Text = "Back->";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UserBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1017, 745);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(btnVote);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserBoard";
            Text = "UserBoard";
            Load += UserBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnVote;
        private Button btnView;
        private Button btnEdit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}