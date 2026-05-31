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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Election_Management_System
{
    public partial class magangeVoter : Form
    {
    
        public magangeVoter()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO login(Username,Contact,Password, Gender, Age, Cnic,Role) values (@name,@contact,@password, @gender, @age, @cnic,'User');";
                SQLiteCommand cmd =
                        new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtBoxN.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGen.Text);
                cmd.Parameters.AddWithValue("@age", cmbAge.Text);
                cmd.Parameters.AddWithValue("@cnic", txtCnic.Text);
                cmd.Parameters.AddWithValue("@contact", txtBoxCon.Text);
                cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
                cmd.ExecuteNonQuery();


                //conn.Close();
                MessageBox.Show("Voter Added");
                LoadVoter();
                ClearFields();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            AdminDashboard admin = new AdminDashboard();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
            this.Hide();
        }

        private void magangeVoter_Load(object sender, EventArgs e)
        {
            LoadVoter();
            {

                cmbGen.Items.AddRange(new object[] {
                "Male",
                "Female"
            });
                for (int i = 18; i < 70; i++)
                {
                    cmbAge.Items.Add(i);
                }
                //LoadVoter();
            }
        }
        void LoadVoter()
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM login";
                SQLiteDataAdapter ad = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView2.DataSource = dt;
                UpdateToatalVoter();
            }
        }
        void ClearFields()
        {
            txtBoxN.Clear();
            txtCnic.Clear();
            txtBoxPass.Clear();
            txtBoxCon.Clear();
            cmbGen.SelectedIndex = -1;
            cmbAge.SelectedIndex = -1;
        }
        void UpdateToatalVoter()
        {
            int total = dataGridView2.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow);
            lblStatus.Text = "Total Voters : " + total;
        }


        private void btnDele_Click_1(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
               
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);
                    conn.Open();

                    string query = "DELETE FROM login WHERE Id=@Id";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                   

                    MessageBox.Show("Voter Deleted");

                    LoadVoter();
                }

                else
                {
                    MessageBox.Show("Select Row First");
                }
            }
        }
    }
}


    



