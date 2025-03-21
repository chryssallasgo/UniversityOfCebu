namespace UniversityOfCebu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnlog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usrnm = new System.Windows.Forms.TextBox();
            this.pswrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnregis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(130, 350);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(100, 29);
            this.btnlog.TabIndex = 0;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // usrnm
            // 
            this.usrnm.Location = new System.Drawing.Point(130, 247);
            this.usrnm.Name = "usrnm";
            this.usrnm.Size = new System.Drawing.Size(100, 20);
            this.usrnm.TabIndex = 3;
            // 
            // pswrd
            // 
            this.pswrd.Location = new System.Drawing.Point(130, 298);
            this.pswrd.Name = "pswrd";
            this.pswrd.Size = new System.Drawing.Size(100, 20);
            this.pswrd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 78);
            this.label3.TabIndex = 5;
            this.label3.Text = "College \r\nDatabase";
            // 
            // btnregis
            // 
            this.btnregis.BackColor = System.Drawing.Color.Transparent;
            this.btnregis.FlatAppearance.BorderSize = 0;
            this.btnregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregis.ForeColor = System.Drawing.Color.Silver;
            this.btnregis.Location = new System.Drawing.Point(186, 427);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(100, 29);
            this.btnregis.TabIndex = 6;
            this.btnregis.Text = "Register";
            this.btnregis.UseVisualStyleBackColor = false;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(286, 457);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pswrd);
            this.Controls.Add(this.usrnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlog);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrnm;
        private System.Windows.Forms.TextBox pswrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnregis;
    }
}