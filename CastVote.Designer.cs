namespace Election_Management_System
{
    partial class CastVote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastVote));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnSave = new Button();
            button2 = new Button();
            label2 = new Label();
            lblWel = new Label();
            label3 = new Label();
            label4 = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1003, 254);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(978, 54);
            label1.TabIndex = 1;
            label1.Text = "             Online Election Management System           ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(356, 570);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 71);
            btnSave.TabIndex = 2;
            btnSave.Text = "Vote";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(546, 570);
            button2.Name = "button2";
            button2.Size = new Size(149, 71);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(435, 77);
            label2.Name = "label2";
            label2.Size = new Size(160, 45);
            label2.TabIndex = 4;
            label2.Text = "Cast Vote";
            // 
            // lblWel
            // 
            lblWel.AutoSize = true;
            lblWel.Location = new Point(449, 146);
            lblWel.Name = "lblWel";
            lblWel.Size = new Size(0, 25);
            lblWel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(40, 247);
            label3.Name = "label3";
            label3.Size = new Size(178, 32);
            label3.TabIndex = 6;
            label3.Text = "All Candidates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Azure;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(890, 199);
            label4.Name = "label4";
            label4.Size = new Size(135, 64);
            label4.TabIndex = 7;
            label4.Text = "Your Vote\r\nYour Voice";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.DarkOrchid;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ButtonHighlight;
            lblStatus.Location = new Point(449, 656);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(160, 32);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status :         ";
            lblStatus.Click += lblStatus_Click;
            // 
            // CastVote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_12_2039281;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1069, 718);
            Controls.Add(lblStatus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblWel);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "CastVote";
            Text = "CastVote";
            Load += CastVote_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnSave;
        private Button button2;
        private Label label2;
        private Label lblWel;
        private Label label3;
        private Label label4;
        private Label lblStatus;
    }
}