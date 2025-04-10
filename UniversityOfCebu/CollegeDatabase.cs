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
    public partial class CollegeDatabase: Form
    {
        public CollegeDatabase()
        {
            InitializeComponent();
            LoadColleges();
            LoadDepartments();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.database1DataSet4.Department);
            // TODO: This line of code loads data into the 'database1DataSet3.College' table. You can move, or remove it, as needed.
            this.collegeTableAdapter.Fill(this.database1DataSet3.College);
            // TODO: This line of code loads data into the 'database1DataSet2.Department' table. You can move, or remove it, as needed.
            LoadCollegesIntoComboBox();
            /*// TODO: This line of code loads data into the 'database1DataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.database1DataSet.Department);
            // TODO: This line of code loads data into the 'database1DataSet.College' table. You can move, or remove it, as needed.
            this.collegeTableAdapter.Fill(this.database1DataSet.College);
            // TODO: This line of code loads data into the 'database1DataSet.College' table. You can move, or remove it, as needed.
            this.collegeTableAdapter.Fill(this.database1DataSet.College);*/

        }

        private void depcode_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void depname_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                colid.Text = row.Cells["CollegeID"].Value.ToString();
                colname.Text = row.Cells["CollegeName"].Value.ToString();
                colcode.Text = row.Cells["CollegeCode"].Value.ToString();
                chckActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }

        }

        private void LoadColleges()
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM College";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt; // Bind to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading colleges: " + ex.Message);
            }
        }

        private void AddCollege()
        {
            // Retrieve values from UI components
            string name = colname.Text.Trim();
            string code = colcode.Text.Trim();
            bool isActive = chckActive.Checked;

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please enter both College Name and College Code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Check if CollegeName or CollegeCode already exists
                    string checkQuery = "SELECT COUNT(*) FROM College WHERE CollegeName = @name OR CollegeCode = @code";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@name", name);
                        checkCmd.Parameters.AddWithValue("@code", code);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("A college with the same Name or Code already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new College record
                    string query = "INSERT INTO College (CollegeName, CollegeCode, IsActive) VALUES (@name, @code, @isActive)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@isActive", isActive);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("College added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Refresh the DataGridView and ComboBox
                LoadColleges();
                LoadCollegesIntoComboBox();

                // Clear input fields
                colname.Clear();
                colcode.Clear();
                chckActive.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding college: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCol_Click(object sender, EventArgs e)
        {
            AddCollege();
        }
        private void UpdateCollege(int id, string name, string code)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM College WHERE CollegeName = @name OR CollegeCode = @code";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@name", name);
                    checkCmd.Parameters.AddWithValue("@code", code);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("A college with the same Name or Code already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                conn.Open();
                string query = "UPDATE College SET CollegeName=@name, CollegeCode=@code WHERE CollegeID=@id";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@code", code);
           
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("College updated successfully!");
            }
        }

        private void upCol_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(colid.Text) ||
                string.IsNullOrWhiteSpace(colname.Text) ||
                string.IsNullOrWhiteSpace(colcode.Text))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(colid.Text, out id))
            {
                MessageBox.Show("Invalid College ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm update action
            DialogResult result = MessageBox.Show("Are you sure you want to update this college?", "Confirm Update",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateCollege(id, colname.Text, colcode.Text);
                LoadColleges();
                MessageBox.Show("College updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DeleteCollege(int id)
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE College SET IsActive=False WHERE CollegeID=@id";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("College deactivated successfully!");
            }
        }

        private void delCol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(colid.Text))
            {
                MessageBox.Show("Please enter a College ID to deactivate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(colid.Text, out id))
            {
                MessageBox.Show("Invalid College ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

      
            DialogResult result = MessageBox.Show("Are you sure you want to deactivate this college?", "Confirm Deactivation",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteCollege(id);
                LoadColleges();
            }
        }

        private void LoadDepartments()
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Department";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void AddDepartment()
        {
            // Validate Inputs
            if (string.IsNullOrWhiteSpace(depname.Text) || string.IsNullOrWhiteSpace(depcode.Text) || cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields and select a college.");
                return;
            }

            string name = depname.Text.Trim();
            string code = depcode.Text.Trim();
            bool isActive = chckActive1.Checked;
            int collegeID = Convert.ToInt32(cmbCollege.SelectedValue); // Get selected CollegeID

            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Department (CollegeID, DepartmentName, DepartmentCode, IsActive) VALUES (@collegeID, @name, @code, @isActive)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@collegeID", collegeID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department added successfully!");
            }

            LoadDepartments();
        }

        private void addDep_Click(object sender, EventArgs e)
        {
            AddDepartment();
            LoadDepartments();
        }

        private void LoadCollegesIntoComboBox()
        {
            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT CollegeID, CollegeName FROM College WHERE IsActive=True";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbCollege.DataSource = dt;
                cmbCollege.DisplayMember = "CollegeName"; 
                cmbCollege.ValueMember = "CollegeID"; 
            }
        }

        private void UpdateDepartment()
        {
            
            if (string.IsNullOrWhiteSpace(depid.Text) || string.IsNullOrWhiteSpace(depname.Text) ||
                string.IsNullOrWhiteSpace(depcode.Text) || cmbCollege.SelectedValue == null)
            {
                MessageBox.Show("Please select a department and fill in all fields.");
                return;
            }

            int departmentID = Convert.ToInt32(depid.Text);  
            int collegeID = Convert.ToInt32(cmbCollege.SelectedValue); 
            string name = depname.Text.Trim();
            string code = depcode.Text.Trim();
            bool isActive = chckActive1.Checked;

            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Department SET CollegeID = @collegeID, DepartmentName = @name, DepartmentCode = @code, IsActive = @isActive WHERE DepartmentID = @id";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@collegeID", collegeID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                cmd.Parameters.AddWithValue("@id", departmentID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department updated successfully!");
            }
        }

        private void upDep_Click(object sender, EventArgs e)
        {
            UpdateDepartment();
            LoadDepartments();
        }

        private void DeleteDepartment(int id)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to deactivate this department?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Department SET IsActive = False WHERE DepartmentID = @id";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department deactivated successfully!");
                }
            }
        }

        private void upDel_Click(object sender, EventArgs e)
        {
            
        if (!string.IsNullOrWhiteSpace(depid.Text))
                {
                    int id = Convert.ToInt32(depid.Text);
                    DeleteDepartment(id);
                    LoadDepartments(); 
        }
        else
        {
          MessageBox.Show("Please select a department to delete.");
        }
         

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                depid.Text = row.Cells["DepartmentID"].Value.ToString();
                cmbCollege.SelectedValue = row.Cells["CollegeIDs"].Value;
                depname.Text = row.Cells["DepartmentNamee"].Value.ToString();
                depcode.Text = row.Cells["DepartmentCoded"].Value.ToString();
                chckActive1.Checked = Convert.ToBoolean(row.Cells["IsActive2"].Value);
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                // Uncomment the next line if you want to redirect to the login form
                // new LoginForm().Show();
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
            // or this.Hide();
        }
    }
}

