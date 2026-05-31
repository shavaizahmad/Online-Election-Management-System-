using Election_Management_System.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Election_Management_System
{
    public partial class EditProfile : Form
    {
        public EditProfile(string cnic)
        {
            InitializeComponent();
            loggedincnic = cnic;
        }
        string loggedincnic;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Step 1 — Empty check
            if (string.IsNullOrWhiteSpace(txtBoxOld.Text) ||
                string.IsNullOrWhiteSpace(txtBoxP.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNew.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNP.Text))
            {
                MessageBox.Show("Please Fill All Field", "Empty ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string checkQuery = @"SELECT COUNT(*) FROM login 
                                      WHERE Cnic     = @cnic 
                                      AND   contact  = @oldContact 
                                      AND   Password = @oldPassword";

                SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@cnic", loggedincnic);
                checkCmd.Parameters.AddWithValue("@oldContact", txtBoxOld.Text.Trim());
                checkCmd.Parameters.AddWithValue("@oldPassword", txtBoxP.Text);

                int found = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (found == 0)
                {
                    MessageBox.Show("Wrong Information",
                        "Verification Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string updateQuery = @"UPDATE login 
                                       SET contact  = @newContact,
                                           Password = @newPassword
                                       WHERE Cnic   = @cnic";

                SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@newContact", txtBoxNew.Text.Trim());
                updateCmd.Parameters.AddWithValue("@newPassword", txtBoxNP.Text);
                updateCmd.Parameters.AddWithValue("@cnic", loggedincnic);

                int rows = updateCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Profile Update Successfully ", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBoxOld.Clear();
                    txtBoxP.Clear();
                    txtBoxNew.Clear();
                    txtBoxNP.Clear();
                }
                else
                {
                    MessageBox.Show("Invalide Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            UserBoard user = new UserBoard(loggedincnic);
            user.FormClosed += (s, args) => this.Close();
            user.Show();
            this.Hide();
        }
    }
}
    

