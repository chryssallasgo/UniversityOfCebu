using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityOfCebu
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            // Retrieve values from UI components
            string regname = regusrnm.Text;
            string email = regemail.Text;
            string pswrd = regpswrd.Text;


            // Validate inputs
            if (string.IsNullOrEmpty(regname) || string.IsNullOrEmpty(pswrd) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO [User] ([username], [password], [email]) VALUES (?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Order matters for OleDb - must match the order in VALUES (?, ?, ?)
                        cmd.Parameters.AddWithValue("?", regname);  // Username
                        cmd.Parameters.AddWithValue("?", pswrd);    // Password
                        cmd.Parameters.AddWithValue("?", email);    // Email

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Login login = new Login();
                        login.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding User please check your inputs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckShowPassword.Checked)
            {
                regpswrd.PasswordChar = '\0'; // Show password
            }
            else
            {
                regpswrd.PasswordChar = '*'; // Hide password
            }
        }
    }
}
