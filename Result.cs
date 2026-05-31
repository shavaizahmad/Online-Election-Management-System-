using Election_Management_System;
using Election_Management_System.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Election_Management_System
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblWinner_Click(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {

            TotalVoters();
            TotalVotes();
            lblWinner.Text = "Winner Not Declared";
        }
        private void LoadResults()
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {

                conn.Open();

                string query = @"
                SELECT candidate.name AS candidateName, candidate.party AS party, COUNT(Votes.CandidateId) AS TotalVotes
                FROM candidate
                LEFT JOIN Votes 
                ON candidate.id = Votes.CandidateId
                GROUP BY candidate.id, candidate.name, candidate.party
                ORDER BY TotalVotes DESC";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }



        private void TotalVoters()
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                try
                {

                    conn.Open();

                    string query = "SELECT COUNT(*) FROM login";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    int total = Convert.ToInt32(cmd.ExecuteScalar());

                    lblVoter.Text = "Total Voters : " + total;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //conn.Close();
            }
        }
        private void TotalVotes()
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Votes";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    int total = Convert.ToInt32(cmd.ExecuteScalar());

                    lblVote.Text = "Total Votes : " + total;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }      //conn.Close();

        }






        private void btnDeclare_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    candidate.name,
                    COUNT(Votes.CandidateId) AS TotalVotes
                FROM candidate
                LEFT JOIN Votes
                ON candidate.id = Votes.CandidateId
                GROUP BY candidate.id
                ORDER BY TotalVotes DESC
                LIMIT 1";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lblWinner.Text = "Winner : " + dr["name"].ToString();
                        }
                        dataGridView1.Visible = true;
                        LoadResults();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
            this.Hide();
        }

        private void lblVoter_Click(object sender, EventArgs e)
        {

        }
    }
}
  