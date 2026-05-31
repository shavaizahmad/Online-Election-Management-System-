namespace Election_Management_System
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblVote = new Label();
            lblVoter = new Label();
            panel1 = new Panel();
            btnDeclare = new Button();
            lblWinner = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(426, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(576, 293);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(66, 9);
            label2.Name = "label2";
            label2.Size = new Size(871, 60);
            label2.TabIndex = 26;
            label2.Text = "    Online Election Management System   ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(426, 159);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 27;
            label1.Text = "Ranking List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(482, 82);
            label3.Name = "label3";
            label3.Size = new Size(111, 45);
            label3.TabIndex = 28;
            label3.Text = "Result";
            // 
            // lblVote
            // 
            lblVote.AutoSize = true;
            lblVote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVote.ForeColor = Color.Navy;
            lblVote.Location = new Point(12, 99);
            lblVote.Name = "lblVote";
            lblVote.Size = new Size(149, 32);
            lblVote.TabIndex = 29;
            lblVote.Text = "Total Vote : ";
            // 
            // lblVoter
            // 
            lblVoter.AutoSize = true;
            lblVoter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVoter.ForeColor = Color.Navy;
            lblVoter.Location = new Point(12, 42);
            lblVoter.Name = "lblVoter";
            lblVoter.Size = new Size(170, 32);
            lblVoter.TabIndex = 30;
            lblVoter.Text = "Total Voters : ";
            lblVoter.Click += lblVoter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDeclare);
            panel1.Controls.Add(lblVoter);
            panel1.Controls.Add(lblVote);
            panel1.Location = new Point(30, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 293);
            panel1.TabIndex = 31;
            // 
            // btnDeclare
            // 
            btnDeclare.BackColor = Color.Navy;
            btnDeclare.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeclare.ForeColor = Color.White;
            btnDeclare.Location = new Point(36, 198);
            btnDeclare.Name = "btnDeclare";
            btnDeclare.Size = new Size(158, 54);
            btnDeclare.TabIndex = 31;
            btnDeclare.Text = "Declare Result";
            btnDeclare.UseVisualStyleBackColor = false;
            btnDeclare.Click += btnDeclare_Click;
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.BackColor = Color.Fuchsia;
            lblWinner.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWinner.ForeColor = Color.White;
            lblWinner.Location = new Point(426, 537);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(156, 45);
            lblWinner.TabIndex = 32;
            lblWinner.Text = "Winner : ";
            lblWinner.Click += lblWinner_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(872, 537);
            button1.Name = "button1";
            button1.Size = new Size(116, 54);
            button1.TabIndex = 32;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 640);
            Controls.Add(button1);
            Controls.Add(lblWinner);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Result";
            Text = "Result";
            Load += Result_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblVote;
        private Label lblVoter;
        private Panel panel1;
        private Button btnDeclare;
        private Label lblWinner;
        private Button button1;
    }
}