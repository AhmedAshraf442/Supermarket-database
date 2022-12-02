namespace WindowsFormsApp1
{
    partial class customers
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
            this.intrroo = new System.Windows.Forms.Label();
            this.userr = new System.Windows.Forms.Label();
            this.pas = new System.Windows.Forms.Label();
            this.useer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sign_up = new System.Windows.Forms.Button();
            this.zip = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.citty = new System.Windows.Forms.TextBox();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.TextBox();
            this.phonne = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // intrroo
            // 
            this.intrroo.AutoSize = true;
            this.intrroo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intrroo.Location = new System.Drawing.Point(183, 9);
            this.intrroo.Name = "intrroo";
            this.intrroo.Size = new System.Drawing.Size(529, 30);
            this.intrroo.TabIndex = 14;
            this.intrroo.Text = "Please, Enter the following information";
            this.intrroo.Click += new System.EventHandler(this.label1_Click);
            // 
            // userr
            // 
            this.userr.AutoSize = true;
            this.userr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userr.Location = new System.Drawing.Point(12, 290);
            this.userr.Name = "userr";
            this.userr.Size = new System.Drawing.Size(105, 24);
            this.userr.TabIndex = 15;
            this.userr.Text = "Username";
            this.userr.Click += new System.EventHandler(this.userr_Click);
            // 
            // pas
            // 
            this.pas.AutoSize = true;
            this.pas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pas.Location = new System.Drawing.Point(464, 290);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(100, 24);
            this.pas.TabIndex = 16;
            this.pas.Text = "Password";
            this.pas.Click += new System.EventHandler(this.pas_Click);
            // 
            // useer
            // 
            this.useer.Location = new System.Drawing.Point(137, 295);
            this.useer.Name = "useer";
            this.useer.Size = new System.Drawing.Size(240, 20);
            this.useer.TabIndex = 17;
            this.useer.TextChanged += new System.EventHandler(this.useer_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(586, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(240, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Sign_up
            // 
            this.Sign_up.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_up.Location = new System.Drawing.Point(394, 362);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(114, 37);
            this.Sign_up.TabIndex = 19;
            this.Sign_up.Text = "Sign up";
            this.Sign_up.UseVisualStyleBackColor = false;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.Location = new System.Drawing.Point(464, 234);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(94, 24);
            this.zip.TabIndex = 21;
            this.zip.Text = "ZIP code";
            this.zip.Click += new System.EventHandler(this.zip_Click);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.SystemColors.ControlDark;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(464, 173);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(44, 24);
            this.city.TabIndex = 22;
            this.city.Text = "City";
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.ControlDark;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(464, 114);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(69, 24);
            this.email.TabIndex = 23;
            this.email.Text = "E-mail";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(464, 60);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(105, 24);
            this.lname.TabIndex = 24;
            this.lname.Text = "Last name";
            this.lname.Click += new System.EventHandler(this.label8_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.BackColor = System.Drawing.SystemColors.ControlDark;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(12, 234);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(56, 24);
            this.state.TabIndex = 25;
            this.state.Text = "State";
            this.state.Click += new System.EventHandler(this.state_Click);
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.BackColor = System.Drawing.SystemColors.ControlDark;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(12, 173);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(64, 24);
            this.street.TabIndex = 26;
            this.street.Text = "Street";
            this.street.Click += new System.EventHandler(this.street_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(12, 114);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(71, 24);
            this.phone.TabIndex = 27;
            this.phone.Text = "Phone";
            this.phone.Click += new System.EventHandler(this.label11_Click);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(12, 60);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(108, 24);
            this.fname.TabIndex = 28;
            this.fname.Text = "First name";
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(586, 239);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(240, 20);
            this.zipCode.TabIndex = 29;
            this.zipCode.TextChanged += new System.EventHandler(this.zipCode_TextChanged);
            // 
            // citty
            // 
            this.citty.Location = new System.Drawing.Point(586, 178);
            this.citty.Name = "citty";
            this.citty.Size = new System.Drawing.Size(240, 20);
            this.citty.TabIndex = 30;
            this.citty.TextChanged += new System.EventHandler(this.citty_TextChanged);
            // 
            // e_mail
            // 
            this.e_mail.Location = new System.Drawing.Point(586, 118);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(240, 20);
            this.e_mail.TabIndex = 31;
            this.e_mail.TextChanged += new System.EventHandler(this.e_mail_TextChanged);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(586, 64);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(240, 20);
            this.last.TabIndex = 32;
            this.last.TextChanged += new System.EventHandler(this.last_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(137, 238);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(240, 20);
            this.textBox7.TabIndex = 33;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(137, 173);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(240, 20);
            this.st.TabIndex = 34;
            this.st.TextChanged += new System.EventHandler(this.st_TextChanged);
            // 
            // phonne
            // 
            this.phonne.Location = new System.Drawing.Point(137, 118);
            this.phonne.Name = "phonne";
            this.phonne.Size = new System.Drawing.Size(240, 20);
            this.phonne.TabIndex = 35;
            this.phonne.TextChanged += new System.EventHandler(this.phonne_TextChanged);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(137, 64);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(240, 20);
            this.first.TabIndex = 36;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.first);
            this.Controls.Add(this.phonne);
            this.Controls.Add(this.st);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.last);
            this.Controls.Add(this.e_mail);
            this.Controls.Add(this.citty);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.street);
            this.Controls.Add(this.state);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.email);
            this.Controls.Add(this.city);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.useer);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.userr);
            this.Controls.Add(this.intrroo);
            this.Name = "customers";
            this.Text = "customers";
            this.Load += new System.EventHandler(this.customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intrroo;
        private System.Windows.Forms.Label userr;
        private System.Windows.Forms.Label pas;
        private System.Windows.Forms.TextBox useer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.Label zip;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.TextBox citty;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.TextBox phonne;
        private System.Windows.Forms.TextBox first;
    }
}