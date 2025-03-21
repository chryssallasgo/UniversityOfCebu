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
            if (string.IsNullOrEmpty(usrnm.Text) || string.IsNullOrEmpty(pswrd.Text))
            {
                MessageBox.Show("Invalid username or password.", "Unable to Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Users ([Username], [Password]) VALUES (@usrnm, @pswrd)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usrnm", usrnm.Text);
                        cmd.Parameters.AddWithValue("@pswrd", pswrd.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Logged In Successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User does not exist: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
