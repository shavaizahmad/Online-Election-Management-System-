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
    public partial class ViewProfile : Form
    {
        string cnic;
        public ViewProfile(string cnic)
        {
            InitializeComponent();
            userCnic = cnic;
        }
        string userCnic;
        private void ViewProfile_Load(object sender, EventArgs e)
        {



            {
                using (SQLiteConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT Username, cnic, contact, age, gender, Password FROM login WHERE cnic=@cnic";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cnic", userCnic);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lblWel.Text = "Welcome " + dr["Username"].ToString();
                            lblN.Text = "Name : " + dr["Username"].ToString();
                            lblCnic.Text = "CNIC : " + dr["cnic"].ToString();
                            lblNo.Text = "Contact : " + dr["contact"].ToString();
                            lblGen.Text = "Age : " + dr["age"].ToString();
                            lblAge.Text = "Gender : " + dr["gender"].ToString();
                            lblPass.Text = "Password : " + dr["Password"].ToString();

                        }
                    }
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserBoard user = new UserBoard(userCnic);
           
            user.FormClosed += (s, args) => this.Close();
            user.Show();
            this.Hide();
        }
    }
}

