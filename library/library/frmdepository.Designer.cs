namespace Library
{
    partial class frmdepository
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdepository));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtnow = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(879, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره کتاب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(879, 173);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "شماره کاربر :";
            // 
            // txtbookid
            // 
            this.txtbookid.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookid.Location = new System.Drawing.Point(643, 43);
            this.txtbookid.Multiline = true;
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(204, 35);
            this.txtbookid.TabIndex = 2;
            this.txtbookid.Leave += new System.EventHandler(this.txtbookid_Leave);
            // 
            // txtuserid
            // 
            this.txtuserid.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(643, 165);
            this.txtuserid.Multiline = true;
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(204, 35);
            this.txtuserid.TabIndex = 3;
            this.txtuserid.Leave += new System.EventHandler(this.txtuserid_Leave_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "امروز";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "تاریخ امانت :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(468, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 173);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "تاریخ برگشت :";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(224, 165);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(204, 35);
            this.txtdate.TabIndex = 11;
            // 
            // txtnow
            // 
            this.txtnow.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnow.Location = new System.Drawing.Point(224, 43);
            this.txtnow.Multiline = true;
            this.txtnow.Name = "txtnow";
            this.txtnow.Size = new System.Drawing.Size(204, 35);
            this.txtnow.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 33);
            this.button3.TabIndex = 13;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmdepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1055, 470);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtnow);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdepository";
            this.Text = "Depository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtnow;
        private System.Windows.Forms.Button button3;
    }
}