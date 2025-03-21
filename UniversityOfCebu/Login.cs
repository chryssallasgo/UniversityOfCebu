using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UniversityOfCebu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string username = usrnm.Text;
            string password = pswrd.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid username or password.", "Unable to Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM Users WHERE [Username] = @Username AND [Password] = @Password";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Use ExecuteScalar to get the count of matching rows
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            // User exists
                            MessageBox.Show("Logged In Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CollegeDatabase collegeDatabase = new CollegeDatabase();
                            collegeDatabase.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("The username or password you entered does not exist. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User does not exist: " + ex.Message + "Error" + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
