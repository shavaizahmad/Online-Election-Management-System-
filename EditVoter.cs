using Election_Management_System.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Election_Management_System
{
    public partial class EditVoter : Form
    {
        private int voterId;
        public EditVoter(int id, string username, string cnic, string contact,string password, string age, string gender)
        {
            InitializeComponent();
            voterId = id;
            cmbGen.Items.AddRange(new object[] { "Male", "Female" });
            for (int i = 18; i < 70; i++) cmbAge.Items.Add(i);

            txtBoxPass.Text = password;
            txtBoxN.Text = username;
            txtCnic.Text = cnic;
            txtBoxCon.Text = contact;
            cmbAge.Text = age;
            cmbGen.Text = gender;


            txtCnic.ReadOnly = true;
            txtCnic.BackColor = System.Drawing.Color.LightGray;
        }


        private void EditVoter_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxN.Text))
            {
                MessageBox.Show("Empty Name Box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxN.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxCon.Text))
            {
                MessageBox.Show("Empty Contact Box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxCon.Focus();
                return;
            }
            if (cmbGen.SelectedIndex == -1)
            {
                MessageBox.Show("Select Gender First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbAge.SelectedIndex == -1)
            {
                MessageBox.Show("Select Age First .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE login
                                     SET Username = @name,
                                         Contact  = @contact,
                                         Age      = @age,
                                         Gender   = @gender
                                     WHERE Id     = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtBoxN.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtBoxCon.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", cmbAge.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGen.Text);
                    cmd.Parameters.AddWithValue("@id", voterId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Voter Update Successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
