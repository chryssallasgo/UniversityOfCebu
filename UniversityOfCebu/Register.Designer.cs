namespace UniversityOfCebu
{
    partial class Register
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
            this.btnback = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.regpswrd = new System.Windows.Forms.TextBox();
            this.regusrnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.regemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.Color.Silver;
            this.btnback.Location = new System.Drawing.Point(337, 375);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 29);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "Back to Login";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(214, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 117);
            this.label3.TabIndex = 12;
            this.label3.Text = "College \r\nDatabase\r\nRegister Form";
            // 
            // regpswrd
            // 
            this.regpswrd.Location = new System.Drawing.Point(304, 258);
            this.regpswrd.Name = "regpswrd";
            this.regpswrd.Size = new System.Drawing.Size(100, 20);
            this.regpswrd.TabIndex = 11;
            // 
            // regusrnm
            // 
            this.regusrnm.Location = new System.Drawing.Point(304, 184);
            this.regusrnm.Name = "regusrnm";
            this.regusrnm.Size = new System.Drawing.Size(100, 20);
            this.regusrnm.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(218, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(304, 310);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(100, 29);
            this.btnreg.TabIndex = 7;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // regemail
            // 
            this.regemail.Location = new System.Drawing.Point(304, 223);
            this.regemail.Name = "regemail";
            this.regemail.Size = new System.Drawing.Size(100, 20);
            this.regemail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(218, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.Silver;
            this.btnexit.Location = new System.Drawing.Point(198, 375);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 29);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityOfCebu.Properties.Resources.red_orange_gradient_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.regemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regpswrd);
            this.Controls.Add(this.regusrnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreg);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regpswrd;
        private System.Windows.Forms.TextBox regusrnm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox regemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnexit;
    }
}