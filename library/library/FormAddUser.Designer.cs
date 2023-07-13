namespace library
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.submitAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(473, 46);
            this.txtname.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 34);
            this.txtname.TabIndex = 0;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(473, 143);
            this.txtlname.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtlname.Multiline = true;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(200, 34);
            this.txtlname.TabIndex = 1;
            this.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // telTxt
            // 
            this.telTxt.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTxt.Location = new System.Drawing.Point(473, 238);
            this.telTxt.MinimumSize = new System.Drawing.Size(200, 30);
            this.telTxt.Multiline = true;
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(200, 34);
            this.telTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 10F);
            this.label1.Location = new System.Drawing.Point(786, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 10F);
            this.label2.Location = new System.Drawing.Point(720, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 10F);
            this.label3.Location = new System.Drawing.Point(719, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره تماس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 10F);
            this.label4.Location = new System.Drawing.Point(376, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "عکس";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Vazir", 11F);
            this.linkLabel1.Location = new System.Drawing.Point(204, 362);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 30);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تغییر تصویر";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // submitAddUser
            // 
            this.submitAddUser.Font = new System.Drawing.Font("Vazir", 12F);
            this.submitAddUser.Location = new System.Drawing.Point(539, 351);
            this.submitAddUser.Name = "submitAddUser";
            this.submitAddUser.Size = new System.Drawing.Size(134, 49);
            this.submitAddUser.TabIndex = 8;
            this.submitAddUser.Text = "ثبت";
            this.submitAddUser.UseVisualStyleBackColor = true;
            this.submitAddUser.Click += new System.EventHandler(this.submitAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(107, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(107, 53);
            this.idTxtBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.idTxtBox.Multiline = true;
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(200, 34);
            this.idTxtBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 10F);
            this.label5.Location = new System.Drawing.Point(376, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "شماره";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(866, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submitAddUser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddUser";
            this.Text = "User";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtlname;
        public System.Windows.Forms.TextBox telTxt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Button submitAddUser;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox idTxtBox;
        public System.Windows.Forms.Label label5;
    }
}