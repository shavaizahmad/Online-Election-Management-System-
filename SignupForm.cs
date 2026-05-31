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
using static System.Net.Mime.MediaTypeNames;


namespace Election_Management_System
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }


        private void btnsignup_Click(object sender, EventArgs e)
        {
            {
                //DBConnection db = new DBConnection();
                using (SQLiteConnection conn = DBConnection.GetConnection())
                {
                    
                    conn.Open();

                    string query = "INSERT INTO login(Username, Cnic , Password, Contact,Age,Gender,Role) VALUES (@name,@cnic,@password,@contact,@age ,@gender, 'User');";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtBoxn.Text);
                    cmd.Parameters.AddWithValue("@cnic", txtBoxCnic.Text);
                    cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
                    cmd.Parameters.AddWithValue("@contact", TxtBoxNo.Text);
                    cmd.Parameters.AddWithValue("@age", cmbAge.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGen.Text);

                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Sign Up Successfully", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //conn.Close();
                    Form1 login = new Form1();
                    login.FormClosed += (s, args) => this.Close();
                    login.Show();
                    this.Hide();
                    

                }
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            cmbGen.Items.AddRange(new object[] {
                "Male",
                "Female"
            });
            for (int i = 18; i < 70; i++)
            {
                cmbAge.Items.Add(i);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
