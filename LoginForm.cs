using Election_Management_System.DataBase;
using System.CodeDom;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Election_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Admin ")
            {
                MessageBox.Show("Please Login", "Admin Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                if (cmbRole.Text == "User")
                {
                    SignupForm sign = new SignupForm();
                    sign.FormClosed += (s, args) => this.Close();
                    sign.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Select Role", "Role?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Admin")
            {

                if (txtBoxN.Text == "3333" && txtBoxPass.Text == "1234")
                {
                    MessageBox.Show("Admin Login Successful");

                    AdminDashboard dash = new AdminDashboard();
                    dash.FormClosed += (s, args) => this.Close();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Information", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            using (SQLiteConnection conn = DBConnection.GetConnection())

            {
                conn.Open();

                string query = "select Role from login where Cnic = @CNIC AND Password=@password AND Role = 'User'";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@CNIC", txtBoxN.Text);
                cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())

                    {

                        //string cnic = txtBoxN.Text;
                        panel1.Visible = true;
                        label4.Text = "Welcome";
                        label5.Text = "Login Successfully";
                        label6.Text = "Best Of Luck";
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        panel1.Visible = true;
                        pictureBox1.Visible = true;
                        timer1.Start();
                        //MessageBox.Show("Welcome, Login Successfully");

                        //UserBoard board = new UserBoard(cnic);
                        //board.FormClosed += (s, args) => this.Close();
                        //board.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                        "Invalid CNIC or Password! Try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    }
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string cnic = txtBoxN.Text;
            timer1.Stop();
            UserBoard board = new UserBoard(cnic);
            board.FormClosed += (s, args) => this.Close();
            board.Show();
            this.Hide();
        }
    }
}
  
        
    
