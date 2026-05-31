using Election_Management_System.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace Election_Management_System
{
    public partial class CastVote : Form
    {
        //DBConnection db = new DBConnection();
        //SQLiteConnection conn = DBConnection.GetConnection();

        public CastVote(string cnic)
        {
            InitializeComponent();
            loggedInCnic = cnic;
        }
        string loggedInCnic;


        private void button2_Click(object sender, EventArgs e)
        {

            UserBoard user = new UserBoard(loggedInCnic);
            user.FormClosed += (s, args) => this.Close();
            user.Show();
            this.Hide();
        }

        private void CastVote_Load_1(object sender, EventArgs e)
        {
            LoadCandidate();
            CheckIfAlreadyVoted();
        }
        void LoadCandidate()
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM candidate";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                //conn.Close();
            }
        }
        void CheckIfAlreadyVoted()
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT  HasVoted FROM login WHERE cnic =@CNIC";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@CNIC", loggedInCnic);

                object result = cmd.ExecuteScalar();

                //conn.Close();

                if (result != null && Convert.ToInt32(result) == 1)
                {
                    MessageBox.Show("You have already voted!");
                    btnSave.Enabled = false;
                    dataGridView1.Enabled = false;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a candidate first!");
                return;
            }

            int candidateId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["id"].Value);
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {

                conn.Open();
                SQLiteTransaction transaction = conn.BeginTransaction();
                try
                {


                    // Save vote
                    string insertVote = @"INSERT INTO Votes (CandidateId, CNIC) VALUES (@CandidateId, @CNIC)";

                    SQLiteCommand cmd1 = new SQLiteCommand(insertVote, conn);

                    cmd1.Parameters.AddWithValue("@CandidateId", candidateId);
                    cmd1.Parameters.AddWithValue("@CNIC", loggedInCnic);

                    cmd1.ExecuteNonQuery();



                    // Mark user as voted
                    string update = @"UPDATE login
                          SET HasVoted = 1
                          WHERE CNIC = @CNIC";

                    SQLiteCommand cmd2 = new SQLiteCommand(update, conn);
                    cmd2.Parameters.AddWithValue("@CNIC", loggedInCnic);

                    cmd2.ExecuteNonQuery();
                    transaction.Commit();
                    //conn.Close();

                    MessageBox.Show("Vote Cast Successfully!");

                    // 🔥 HIDE / DISABLE UI
                    btnSave.Enabled = false;
                    btnSave.Text = "Voted";
                    dataGridView1.Enabled = false;
                    lblStatus.Text = "Thanks for Voting";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}