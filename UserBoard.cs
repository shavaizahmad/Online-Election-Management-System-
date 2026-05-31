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
    public partial class UserBoard : Form
    {

        public UserBoard(string cnic)
        {
            InitializeComponent();
            loggedInCnic = cnic;
        }
        string loggedInCnic;
        private void btnVote_Click(object sender, EventArgs e)
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
                    btnVote.Enabled = false;

                }
                else
                {
                    CastVote cast = new CastVote(loggedInCnic);
                    cast.FormClosed += (s, args) => this.Close();
                    cast.Show();
                    this.Hide();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Form1 login = new Form1();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
            this.Hide();
        }

        private void UserBoard_Load(object sender, EventArgs e)
        {

            {
                using (SQLiteConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT Username FROM login WHERE cnic=@cnic";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cnic", loggedInCnic);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            label2.Text = "Welcome " + dr["Username"].ToString();
                        }
                    }
                }
            }
        }
        //string cnic;
        private void btnView_Click(object sender, EventArgs e)
        {

            ViewProfile view = new ViewProfile(loggedInCnic);
            view.FormClosed += (s, args) => this.Close();
            view.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfile edit= new EditProfile(loggedInCnic);
            edit.FormClosed += (s, args) => this.Close();
            edit.Show();
            this.Hide();
        }
    }
}
