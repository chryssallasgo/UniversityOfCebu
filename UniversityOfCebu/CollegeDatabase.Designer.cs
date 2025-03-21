namespace UniversityOfCebu
{
    partial class CollegeDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeDatabase));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upDel = new System.Windows.Forms.Button();
            this.upDep = new System.Windows.Forms.Button();
            this.addDep = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.depid = new System.Windows.Forms.TextBox();
            this.depcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.depname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chckActive1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addCol = new System.Windows.Forms.Button();
            this.upCol = new System.Windows.Forms.Button();
            this.delCol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colcode = new System.Windows.Forms.TextBox();
            this.colid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chckActive = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.database1DataSet3 = new UniversityOfCebu.Database1DataSet3();
            this.collegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeTableAdapter = new UniversityOfCebu.Database1DataSet3TableAdapters.CollegeTableAdapter();
            this.database1DataSet4 = new UniversityOfCebu.Database1DataSet4();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new UniversityOfCebu.Database1DataSet4TableAdapters.DepartmentTableAdapter();
            this.CollegeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegeIDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentNamee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentCoded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentID,
            this.CollegeIDs,
            this.DepartmentNamee,
            this.DepartmentCoded,
            this.isActive2});
            this.dataGridView2.DataSource = this.departmentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 440);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(708, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to College Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(6, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Department";
            // 
            // upDel
            // 
            this.upDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.upDel.FlatAppearance.BorderSize = 0;
            this.upDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upDel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.upDel.Location = new System.Drawing.Point(607, 412);
            this.upDel.Name = "upDel";
            this.upDel.Size = new System.Drawing.Size(113, 22);
            this.upDel.TabIndex = 10;
            this.upDel.Text = "Delete";
            this.upDel.UseVisualStyleBackColor = false;
            this.upDel.Click += new System.EventHandler(this.upDel_Click);
            // 
            // upDep
            // 
            this.upDep.BackColor = System.Drawing.Color.RoyalBlue;
            this.upDep.FlatAppearance.BorderSize = 0;
            this.upDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upDep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upDep.Location = new System.Drawing.Point(488, 412);
            this.upDep.Name = "upDep";
            this.upDep.Size = new System.Drawing.Size(113, 22);
            this.upDep.TabIndex = 9;
            this.upDep.Text = "Update";
            this.upDep.UseVisualStyleBackColor = false;
            this.upDep.Click += new System.EventHandler(this.upDep_Click);
            // 
            // addDep
            // 
            this.addDep.BackColor = System.Drawing.Color.RoyalBlue;
            this.addDep.FlatAppearance.BorderSize = 0;
            this.addDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDep.Location = new System.Drawing.Point(369, 412);
            this.addDep.Name = "addDep";
            this.addDep.Size = new System.Drawing.Size(113, 22);
            this.addDep.TabIndex = 8;
            this.addDep.Text = "Add";
            this.addDep.UseVisualStyleBackColor = false;
            this.addDep.Click += new System.EventHandler(this.addDep_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(249, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "Department ID:";
            // 
            // depid
            // 
            this.depid.BackColor = System.Drawing.Color.DarkGray;
            this.depid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depid.Location = new System.Drawing.Point(329, 347);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(92, 20);
            this.depid.TabIndex = 23;
            // 
            // depcode
            // 
            this.depcode.Location = new System.Drawing.Point(114, 373);
            this.depcode.Name = "depcode";
            this.depcode.Size = new System.Drawing.Size(129, 20);
            this.depcode.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Location = new System.Drawing.Point(18, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Department Code:";
            // 
            // depname
            // 
            this.depname.Location = new System.Drawing.Point(114, 347);
            this.depname.Name = "depname";
            this.depname.Size = new System.Drawing.Size(129, 20);
            this.depname.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(18, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Department Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(249, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "Active?";
            // 
            // chckActive1
            // 
            this.chckActive1.AutoSize = true;
            this.chckActive1.BackColor = System.Drawing.SystemColors.Highlight;
            this.chckActive1.Location = new System.Drawing.Point(329, 376);
            this.chckActive1.Name = "chckActive1";
            this.chckActive1.Size = new System.Drawing.Size(44, 17);
            this.chckActive1.TabIndex = 30;
            this.chckActive1.Text = "Yes";
            this.chckActive1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollegeID,
            this.CollegeName,
            this.CollegeCode,
            this.IsActive});
            this.dataGridView1.DataSource = this.collegeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(708, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addCol
            // 
            this.addCol.BackColor = System.Drawing.Color.RoyalBlue;
            this.addCol.FlatAppearance.BorderSize = 0;
            this.addCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCol.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCol.Location = new System.Drawing.Point(369, 150);
            this.addCol.Name = "addCol";
            this.addCol.Size = new System.Drawing.Size(113, 22);
            this.addCol.TabIndex = 2;
            this.addCol.Text = "Add";
            this.addCol.UseVisualStyleBackColor = false;
            this.addCol.Click += new System.EventHandler(this.addCol_Click);
            // 
            // upCol
            // 
            this.upCol.BackColor = System.Drawing.Color.RoyalBlue;
            this.upCol.FlatAppearance.BorderSize = 0;
            this.upCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upCol.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upCol.Location = new System.Drawing.Point(488, 150);
            this.upCol.Name = "upCol";
            this.upCol.Size = new System.Drawing.Size(113, 22);
            this.upCol.TabIndex = 3;
            this.upCol.Text = "Edit";
            this.upCol.UseVisualStyleBackColor = false;
            this.upCol.Click += new System.EventHandler(this.upCol_Click);
            // 
            // delCol
            // 
            this.delCol.BackColor = System.Drawing.Color.RoyalBlue;
            this.delCol.FlatAppearance.BorderSize = 0;
            this.delCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCol.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCol.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delCol.Location = new System.Drawing.Point(607, 150);
            this.delCol.Name = "delCol";
            this.delCol.Size = new System.Drawing.Size(113, 22);
            this.delCol.TabIndex = 4;
            this.delCol.Text = "Delete";
            this.delCol.UseVisualStyleBackColor = false;
            this.delCol.Click += new System.EventHandler(this.delCol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "College";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(18, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "College Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // colname
            // 
            this.colname.Location = new System.Drawing.Point(114, 85);
            this.colname.Name = "colname";
            this.colname.Size = new System.Drawing.Size(129, 20);
            this.colname.TabIndex = 12;
            this.colname.TextChanged += new System.EventHandler(this.depname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "College Code:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // colcode
            // 
            this.colcode.Location = new System.Drawing.Point(114, 111);
            this.colcode.Name = "colcode";
            this.colcode.Size = new System.Drawing.Size(129, 20);
            this.colcode.TabIndex = 14;
            this.colcode.TextChanged += new System.EventHandler(this.depcode_TextChanged);
            // 
            // colid
            // 
            this.colid.Location = new System.Drawing.Point(312, 85);
            this.colid.Name = "colid";
            this.colid.Size = new System.Drawing.Size(92, 20);
            this.colid.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(249, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "College ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(249, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "Active?";
            // 
            // chckActive
            // 
            this.chckActive.AutoSize = true;
            this.chckActive.BackColor = System.Drawing.SystemColors.Highlight;
            this.chckActive.Location = new System.Drawing.Point(312, 113);
            this.chckActive.Name = "chckActive";
            this.chckActive.Size = new System.Drawing.Size(44, 17);
            this.chckActive.TabIndex = 29;
            this.chckActive.Text = "Yes";
            this.chckActive.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.Location = new System.Drawing.Point(427, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 14);
            this.label12.TabIndex = 31;
            this.label12.Text = "College ID:";
            // 
            // cmbCollege
            // 
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(488, 346);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(88, 21);
            this.cmbCollege.TabIndex = 32;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collegeBindingSource
            // 
            this.collegeBindingSource.DataMember = "College";
            this.collegeBindingSource.DataSource = this.database1DataSet3;
            // 
            // collegeTableAdapter
            // 
            this.collegeTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.database1DataSet4;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // CollegeID
            // 
            this.CollegeID.DataPropertyName = "CollegeID";
            this.CollegeID.HeaderText = "CollegeID";
            this.CollegeID.Name = "CollegeID";
            // 
            // CollegeName
            // 
            this.CollegeName.DataPropertyName = "CollegeName";
            this.CollegeName.HeaderText = "CollegeName";
            this.CollegeName.Name = "CollegeName";
            // 
            // CollegeCode
            // 
            this.CollegeCode.DataPropertyName = "CollegeCode";
            this.CollegeCode.HeaderText = "CollegeCode";
            this.CollegeCode.Name = "CollegeCode";
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "isActive";
            this.IsActive.HeaderText = "isActive";
            this.IsActive.Name = "IsActive";
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "DepartmentID";
            this.DepartmentID.Name = "DepartmentID";
            // 
            // CollegeIDs
            // 
            this.CollegeIDs.DataPropertyName = "CollegeID";
            this.CollegeIDs.HeaderText = "CollegeID";
            this.CollegeIDs.Name = "CollegeIDs";
            // 
            // DepartmentNamee
            // 
            this.DepartmentNamee.DataPropertyName = "DepartmentName";
            this.DepartmentNamee.HeaderText = "DepartmentName";
            this.DepartmentNamee.Name = "DepartmentNamee";
            // 
            // DepartmentCoded
            // 
            this.DepartmentCoded.DataPropertyName = "DepartmentCode";
            this.DepartmentCoded.HeaderText = "DepartmentCode";
            this.DepartmentCoded.Name = "DepartmentCoded";
            // 
            // isActive2
            // 
            this.isActive2.DataPropertyName = "isActive";
            this.isActive2.HeaderText = "isActive";
            this.isActive2.Name = "isActive2";
            // 
            // CollegeDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 602);
            this.Controls.Add(this.cmbCollege);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chckActive1);
            this.Controls.Add(this.chckActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.depid);
            this.Controls.Add(this.depcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.depname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.colid);
            this.Controls.Add(this.colcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upDel);
            this.Controls.Add(this.upDep);
            this.Controls.Add(this.addDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delCol);
            this.Controls.Add(this.upCol);
            this.Controls.Add(this.addCol);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CollegeDatabase";
            this.Text = "CollegeDatabase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upDel;
        private System.Windows.Forms.Button upDep;
        private System.Windows.Forms.Button addDep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox depid;
        private System.Windows.Forms.TextBox depcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox depname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chckActive1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addCol;
        private System.Windows.Forms.Button upCol;
        private System.Windows.Forms.Button delCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox colcode;
        private System.Windows.Forms.TextBox colid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckActive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCollege;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource collegeBindingSource;
        private Database1DataSet3TableAdapters.CollegeTableAdapter collegeTableAdapter;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private Database1DataSet4TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeIDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentNamee;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCoded;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive2;
    }
}

