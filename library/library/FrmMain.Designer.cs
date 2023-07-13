namespace library
{
    partial class panelMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelMain));
            this.books = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.trust = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.mangAcc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // books
            // 
            this.books.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books.Location = new System.Drawing.Point(950, 145);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(181, 74);
            this.books.TabIndex = 0;
            this.books.Text = "کتاب ها";
            this.books.UseVisualStyleBackColor = true;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.Transparent;
            this.Users.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(950, 46);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(181, 71);
            this.Users.TabIndex = 1;
            this.Users.Text = "کاربران";
            this.Users.UseVisualStyleBackColor = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // trust
            // 
            this.trust.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trust.Location = new System.Drawing.Point(950, 262);
            this.trust.Name = "trust";
            this.trust.Size = new System.Drawing.Size(181, 74);
            this.trust.TabIndex = 2;
            this.trust.Text = "امانت";
            this.trust.UseVisualStyleBackColor = true;
            this.trust.Click += new System.EventHandler(this.trust_Click);
            // 
            // setting
            // 
            this.setting.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.Location = new System.Drawing.Point(950, 491);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(181, 74);
            this.setting.TabIndex = 3;
            this.setting.Text = "تنظیمات";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // mangAcc
            // 
            this.mangAcc.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangAcc.Location = new System.Drawing.Point(950, 378);
            this.mangAcc.Name = "mangAcc";
            this.mangAcc.Size = new System.Drawing.Size(181, 74);
            this.mangAcc.TabIndex = 5;
            this.mangAcc.Text = "مدیریت حساب";
            this.mangAcc.UseVisualStyleBackColor = true;
            this.mangAcc.Click += new System.EventHandler(this.mangAcc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 628);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(950, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "تازه سازی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::library.Properties.Resources.istockphoto_638383032_170667a__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mangAcc);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.trust);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.books);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "panelMain";
            this.Text = "library";
            this.Load += new System.EventHandler(this.panelMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button books;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button trust;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button mangAcc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}