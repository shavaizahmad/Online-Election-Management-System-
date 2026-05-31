using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Election_Management_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCandi_Click(object sender, EventArgs e)
        {
            Candidate can = new Candidate();
            can.FormClosed += (s, args) => this.Close();
            can.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
            this.Hide();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.FormClosed += (s, args) => this.Close();
            result.Show();
            this.Hide();

        }

        private void btnVoter_Click(object sender, EventArgs e)
        {
            magangeVoter voter = new magangeVoter();
            voter.FormClosed += (s, args) => this.Close();
            voter.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
