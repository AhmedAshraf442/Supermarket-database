namespace WindowsFormsApp1
{
    partial class update_products
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
            this.first = new System.Windows.Forms.TextBox();
            this.phonne = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.TextBox();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.Product_id = new System.Windows.Forms.Label();
            this.Category_ID = new System.Windows.Forms.Label();
            this.Product_price = new System.Windows.Forms.Label();
            this.Brand_ID = new System.Windows.Forms.Label();
            this.Product_model_year = new System.Windows.Forms.Label();
            this.Sign_up = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // intrroo
            // 
            this.intrroo.AutoSize = true;
            this.intrroo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intrroo.Location = new System.Drawing.Point(170, 9);
            this.intrroo.Name = "intrroo";
            this.intrroo.Size = new System.Drawing.Size(529, 30);
            this.intrroo.TabIndex = 38;
            this.intrroo.Text = "Please, Enter the following information";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(172, 117);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(240, 20);
            this.first.TabIndex = 70;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
            // 
            // phonne
            // 
            this.phonne.Location = new System.Drawing.Point(172, 171);
            this.phonne.Name = "phonne";
            this.phonne.Size = new System.Drawing.Size(240, 20);
            this.phonne.TabIndex = 69;
            this.phonne.TextChanged += new System.EventHandler(this.phonne_TextChanged);
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(224, 231);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(240, 20);
            this.st.TabIndex = 68;
            this.st.TextChanged += new System.EventHandler(this.st_TextChanged);
            // 
            // e_mail
            // 
            this.e_mail.Location = new System.Drawing.Point(600, 171);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(240, 20);
            this.e_mail.TabIndex = 66;
            this.e_mail.TextChanged += new System.EventHandler(this.e_mail_TextChanged);
            // 
            // Product_id
            // 
            this.Product_id.AutoSize = true;
            this.Product_id.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_id.Location = new System.Drawing.Point(26, 113);
            this.Product_id.Name = "Product_id";
            this.Product_id.Size = new System.Drawing.Size(140, 24);
            this.Product_id.TabIndex = 64;
            this.Product_id.Text = "Product name";
            this.Product_id.Click += new System.EventHandler(this.Product_id_Click);
            // 
            // Category_ID
            // 
            this.Category_ID.AutoSize = true;
            this.Category_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Category_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_ID.Location = new System.Drawing.Point(26, 167);
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.Size = new System.Drawing.Size(118, 24);
            this.Category_ID.TabIndex = 63;
            this.Category_ID.Text = "Category ID";
            this.Category_ID.Click += new System.EventHandler(this.Category_ID_Click);
            // 
            // Product_price
            // 
            this.Product_price.AutoSize = true;
            this.Product_price.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_price.Location = new System.Drawing.Point(449, 166);
            this.Product_price.Name = "Product_price";
            this.Product_price.Size = new System.Drawing.Size(135, 24);
            this.Product_price.TabIndex = 62;
            this.Product_price.Text = "Product price";
            this.Product_price.Click += new System.EventHandler(this.Product_price_Click);
            // 
            // Brand_ID
            // 
            this.Brand_ID.AutoSize = true;
            this.Brand_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Brand_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_ID.Location = new System.Drawing.Point(449, 114);
            this.Brand_ID.Name = "Brand_ID";
            this.Brand_ID.Size = new System.Drawing.Size(90, 24);
            this.Brand_ID.TabIndex = 61;
            this.Brand_ID.Text = "Brand ID";
            this.Brand_ID.Click += new System.EventHandler(this.Brand_ID_Click);
            // 
            // Product_model_year
            // 
            this.Product_model_year.AutoSize = true;
            this.Product_model_year.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Product_model_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_model_year.Location = new System.Drawing.Point(26, 226);
            this.Product_model_year.Name = "Product_model_year";
            this.Product_model_year.Size = new System.Drawing.Size(192, 24);
            this.Product_model_year.TabIndex = 60;
            this.Product_model_year.Text = "Product model year";
            this.Product_model_year.Click += new System.EventHandler(this.Product_model_year_Click);
            // 
            // Sign_up
            // 
            this.Sign_up.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_up.Location = new System.Drawing.Point(384, 274);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(114, 37);
            this.Sign_up.TabIndex = 71;
            this.Sign_up.Text = "Update";
            this.Sign_up.UseVisualStyleBackColor = false;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(600, 118);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(240, 20);
            this.last.TabIndex = 72;
            this.last.TextChanged += new System.EventHandler(this.last_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 74;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // update_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(870, 338);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.first);
            this.Controls.Add(this.phonne);
            this.Controls.Add(this.st);
            this.Controls.Add(this.e_mail);
            this.Controls.Add(this.Product_id);
            this.Controls.Add(this.Category_ID);
            this.Controls.Add(this.Product_price);
            this.Controls.Add(this.Brand_ID);
            this.Controls.Add(this.Product_model_year);
            this.Controls.Add(this.intrroo);
            this.Name = "update_products";
            this.Text = "Update products informations";
            this.Load += new System.EventHandler(this.update_products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intrroo;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox phonne;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.Label Product_id;
        private System.Windows.Forms.Label Category_ID;
        private System.Windows.Forms.Label Product_price;
        private System.Windows.Forms.Label Brand_ID;
        private System.Windows.Forms.Label Product_model_year;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}