namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c_login = new System.Windows.Forms.Button();
            this.Cus = new System.Windows.Forms.GroupBox();
            this.c_signup = new System.Windows.Forms.Button();
            this.admiin = new System.Windows.Forms.GroupBox();
            this.a_signup = new System.Windows.Forms.Button();
            this.a_login = new System.Windows.Forms.Button();
            this.Cus.SuspendLayout();
            this.admiin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to the program";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please, Select are you a Customer or an Admin ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // c_login
            // 
            this.c_login.BackColor = System.Drawing.SystemColors.Info;
            this.c_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_login.Location = new System.Drawing.Point(6, 52);
            this.c_login.Name = "c_login";
            this.c_login.Size = new System.Drawing.Size(114, 37);
            this.c_login.TabIndex = 4;
            this.c_login.Text = "Log in";
            this.c_login.UseVisualStyleBackColor = false;
            this.c_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cus
            // 
            this.Cus.Controls.Add(this.c_signup);
            this.Cus.Controls.Add(this.c_login);
            this.Cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus.Location = new System.Drawing.Point(12, 224);
            this.Cus.Name = "Cus";
            this.Cus.Size = new System.Drawing.Size(275, 131);
            this.Cus.TabIndex = 7;
            this.Cus.TabStop = false;
            this.Cus.Text = "Customer";
            this.Cus.Enter += new System.EventHandler(this.Cus_Enter);
            // 
            // c_signup
            // 
            this.c_signup.BackColor = System.Drawing.SystemColors.Info;
            this.c_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_signup.Location = new System.Drawing.Point(150, 52);
            this.c_signup.Name = "c_signup";
            this.c_signup.Size = new System.Drawing.Size(114, 37);
            this.c_signup.TabIndex = 5;
            this.c_signup.Text = "Sign up";
            this.c_signup.UseVisualStyleBackColor = false;
            this.c_signup.Click += new System.EventHandler(this.c_signup_Click);
            // 
            // admiin
            // 
            this.admiin.Controls.Add(this.a_signup);
            this.admiin.Controls.Add(this.a_login);
            this.admiin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admiin.Location = new System.Drawing.Point(537, 224);
            this.admiin.Name = "admiin";
            this.admiin.Size = new System.Drawing.Size(275, 131);
            this.admiin.TabIndex = 8;
            this.admiin.TabStop = false;
            this.admiin.Text = "Admin";
            this.admiin.Enter += new System.EventHandler(this.admiin_Enter);
            // 
            // a_signup
            // 
            this.a_signup.BackColor = System.Drawing.SystemColors.Info;
            this.a_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_signup.Location = new System.Drawing.Point(150, 52);
            this.a_signup.Name = "a_signup";
            this.a_signup.Size = new System.Drawing.Size(114, 37);
            this.a_signup.TabIndex = 5;
            this.a_signup.Text = "Sign up";
            this.a_signup.UseVisualStyleBackColor = false;
            this.a_signup.Click += new System.EventHandler(this.a_signup_Click);
            // 
            // a_login
            // 
            this.a_login.BackColor = System.Drawing.SystemColors.Info;
            this.a_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_login.Location = new System.Drawing.Point(6, 52);
            this.a_login.Name = "a_login";
            this.a_login.Size = new System.Drawing.Size(114, 37);
            this.a_login.TabIndex = 4;
            this.a_login.Text = "Log in";
            this.a_login.UseVisualStyleBackColor = false;
            this.a_login.Click += new System.EventHandler(this.a_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.admiin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cus);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermarket system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Cus.ResumeLayout(false);
            this.admiin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button c_login;
        private System.Windows.Forms.GroupBox Cus;
        private System.Windows.Forms.Button c_signup;
        private System.Windows.Forms.GroupBox admiin;
        private System.Windows.Forms.Button a_signup;
        private System.Windows.Forms.Button a_login;
    }
}

