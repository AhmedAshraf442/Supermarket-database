namespace WindowsFormsApp1
{
    partial class Admins
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
            this.first = new System.Windows.Forms.TextBox();
            this.phonne = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Sign_up = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.useer = new System.Windows.Forms.TextBox();
            this.pas = new System.Windows.Forms.Label();
            this.userr = new System.Windows.Forms.Label();
            this.intrroo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(226, 130);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(240, 20);
            this.first.TabIndex = 58;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
            // 
            // phonne
            // 
            this.phonne.Location = new System.Drawing.Point(226, 184);
            this.phonne.Name = "phonne";
            this.phonne.Size = new System.Drawing.Size(240, 20);
            this.phonne.TabIndex = 57;
            this.phonne.TextChanged += new System.EventHandler(this.phonne_TextChanged);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(675, 130);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(240, 20);
            this.last.TabIndex = 54;
            this.last.TextChanged += new System.EventHandler(this.last_TextChanged);
            // 
            // e_mail
            // 
            this.e_mail.Location = new System.Drawing.Point(675, 184);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(240, 20);
            this.e_mail.TabIndex = 53;
            this.e_mail.TextChanged += new System.EventHandler(this.e_mail_TextChanged);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(101, 126);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(108, 24);
            this.fname.TabIndex = 50;
            this.fname.Text = "First name";
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(101, 180);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(71, 24);
            this.phone.TabIndex = 49;
            this.phone.Text = "Phone";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.BackColor = System.Drawing.SystemColors.ControlDark;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(101, 239);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(0, 24);
            this.street.TabIndex = 48;
            this.street.Click += new System.EventHandler(this.street_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(553, 126);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(105, 24);
            this.lname.TabIndex = 46;
            this.lname.Text = "Last name";
            this.lname.Click += new System.EventHandler(this.lname_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.ControlDark;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(553, 180);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(69, 24);
            this.email.TabIndex = 45;
            this.email.Text = "E-mail";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // Sign_up
            // 
            this.Sign_up.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_up.Location = new System.Drawing.Point(453, 299);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(114, 37);
            this.Sign_up.TabIndex = 42;
            this.Sign_up.Text = "Sign up";
            this.Sign_up.UseVisualStyleBackColor = false;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(675, 243);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(240, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // useer
            // 
            this.useer.Location = new System.Drawing.Point(226, 244);
            this.useer.Name = "useer";
            this.useer.Size = new System.Drawing.Size(240, 20);
            this.useer.TabIndex = 40;
            this.useer.TextChanged += new System.EventHandler(this.useer_TextChanged);
            // 
            // pas
            // 
            this.pas.AutoSize = true;
            this.pas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pas.Location = new System.Drawing.Point(553, 239);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(100, 24);
            this.pas.TabIndex = 39;
            this.pas.Text = "Password";
            this.pas.Click += new System.EventHandler(this.pas_Click);
            // 
            // userr
            // 
            this.userr.AutoSize = true;
            this.userr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userr.Location = new System.Drawing.Point(101, 239);
            this.userr.Name = "userr";
            this.userr.Size = new System.Drawing.Size(105, 24);
            this.userr.TabIndex = 38;
            this.userr.Text = "Username";
            this.userr.Click += new System.EventHandler(this.userr_Click);
            // 
            // intrroo
            // 
            this.intrroo.AutoSize = true;
            this.intrroo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intrroo.Location = new System.Drawing.Point(240, 28);
            this.intrroo.Name = "intrroo";
            this.intrroo.Size = new System.Drawing.Size(529, 30);
            this.intrroo.TabIndex = 37;
            this.intrroo.Text = "Please, Enter the following information";
            this.intrroo.Click += new System.EventHandler(this.intrroo_Click);
            // 
            // Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1004, 376);
            this.Controls.Add(this.first);
            this.Controls.Add(this.phonne);
            this.Controls.Add(this.last);
            this.Controls.Add(this.e_mail);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.street);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.useer);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.userr);
            this.Controls.Add(this.intrroo);
            this.Name = "Admins";
            this.Text = "Admins";
            this.Load += new System.EventHandler(this.Admins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox phonne;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox useer;
        private System.Windows.Forms.Label pas;
        private System.Windows.Forms.Label userr;
        private System.Windows.Forms.Label intrroo;
    }
}