using Election_Management_System.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Election_Management_System
{
    public partial class EditCandidate : Form
    {
        private int candidateId;
        public EditCandidate(int id, string name, string gender, string age,string seat, string symbol, string party)
        {
      
            InitializeComponent();

            candidateId = id;
            cmbGen.Items.AddRange(new object[] { "Male", "Female" });
            cmbParty.Items.AddRange(new object[] { "PTI", "PPP", "ANP", "MQM", "IND" });
            cmbSeat.Items.AddRange(new object[] { "MNA", "MPA" });
            cmbSym.Items.AddRange(new object[] { "BAT", "ARROW", "KITE", "TORCH", "BOOK" });
            for (int i = 18; i < 70; i++) cmbAge.Items.Add(i);
            txtBoxn.Text = name;
            cmbGen.Text = gender;
            cmbAge.Text = age;
            cmbSeat.Text = seat;
            cmbSym.Text = symbol;
            cmbParty.Text = party;
        }

        private void EditCandidate_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
              //public partial class EditCandidate : Form
       
            // UPDATE BUTTON
           
                if (string.IsNullOrWhiteSpace(txtBoxn.Text))
                {
                    MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SQLiteConnection conn = DBConnection.GetConnection())
                {
              
                    try
                    {
                        conn.Open();
                        string query = @"UPDATE candidate 
                                     SET name   = @name,
                                         gender = @gender,
                                         age    = @age,
                                         seat   = @seat,
                                         symbol = @symbol,
                                         party  = @party
                                     WHERE id   = @id";
                    
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", txtBoxn.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", cmbGen.Text);
                        cmd.Parameters.AddWithValue("@age", cmbAge.Text);
                        cmd.Parameters.AddWithValue("@seat", cmbSeat.Text);
                        cmd.Parameters.AddWithValue("@symbol", cmbSym.Text);
                        cmd.Parameters.AddWithValue("@party", cmbParty.Text);
                        cmd.Parameters.AddWithValue("@id", candidateId);
                      
                    cmd.ExecuteNonQuery();

                        MessageBox.Show("Candidate Update Successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // CANCEL BUTTON
            private void btnCancel_Click(object sender, EventArgs e)
            {

            Candidate admin = new Candidate();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
            this.Hide();
        }
    }
}
    

