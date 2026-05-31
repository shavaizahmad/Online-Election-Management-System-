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
using System.Xml.Linq;
namespace Election_Management_System
{
    public partial class Candidate : Form
    {
        //DBConnection db = new DBConnection();
        //SQLiteConnection conn = DBConnection.GetConnection();
        public Candidate()
        {
            InitializeComponent();
        }

        private void Candidate_Load(object sender, EventArgs e)
        {

            cmbGen.Items.AddRange(new object[] {
                "Male",
                "Female"
            });
            cmbParty.Items.AddRange(new object[] {
                "PTI",
                "PPP",
                "ANP",
                "MQM",
                "IND"
            });
            cmbSeat.Items.AddRange(new object[] {
                "MNA",
                "MPA",
            });
            cmbSym.Items.AddRange(new object[] {
                "BAT",
                "ARROW",
                "KITE",
                "TORCH",
                "BOOK",
            });
            for (int i = 18; i < 70; i++)
            {
                cmbAge.Items.Add(i);

            }

            LoadCandidates();
        }


        void LoadCandidates()
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM candidate";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                UpdateToatalCandidate();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO candidate(name, gender, age, seat, symbol, party) values (@name, @gender, @age, @seat, @symbol, @party);";
                SQLiteCommand cmd =
                        new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtBoxn.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGen.Text);
                cmd.Parameters.AddWithValue("@age", cmbAge.Text);
                cmd.Parameters.AddWithValue("@seat", cmbSeat.Text);
                cmd.Parameters.AddWithValue("@symbol", cmbSym.Text);
                cmd.Parameters.AddWithValue("@party", cmbParty.Text);

                cmd.ExecuteNonQuery();

                //conn.Close();

                MessageBox.Show("Candidate Added");
                LoadCandidates();
                ClearFields();
            }
        }





        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    conn.Open();
                    string vquery =
                        "DELETE FROM Candidate WHERE Id=@Id";

                    string query =
                        "DELETE FROM Candidate WHERE Id=@Id";

                    SQLiteCommand cmd =
                        new SQLiteCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    //conn.Close();

                    MessageBox.Show("Candidate Deleted");

                    LoadCandidates();
                }
                else
                {
                    MessageBox.Show("Select Row First");
                }
            }
        }


        void ClearFields()
        {
            txtBoxn.Clear();
            cmbGen.SelectedIndex = -1;
            cmbParty.SelectedIndex = -1;
            cmbSeat.SelectedIndex = -1;
            cmbAge.SelectedIndex = -1;
            cmbSym.SelectedIndex = -1;

        }
        void UpdateToatalCandidate()
        {
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow);
            lblStatus.Text = "Total Candidates : " + total;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
       
            }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                // Header row double click ignore karo
                if (e.RowIndex < 0) return;

                // Selected row se data uthao
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value?.ToString();
                string gender = row.Cells["gender"].Value?.ToString();
                string age = row.Cells["age"].Value?.ToString();
                string seat = row.Cells["seat"].Value?.ToString();
                string symbol = row.Cells["symbol"].Value?.ToString();
                string party = row.Cells["party"].Value?.ToString();

              
                EditCandidate editForm = new EditCandidate(id, name, gender, age, seat, symbol, party);


                editForm.FormClosed += (s, args) => LoadCandidates();

                editForm.ShowDialog();
            }

                
              
            }
        }
    }
          
        
    

