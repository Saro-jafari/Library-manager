namespace library
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.addBookBtn = new System.Windows.Forms.Button();
            this.deletBookBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Button();
            this.dtabook = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dtabook)).BeginInit();
            this.SuspendLayout();
            // 
            // addBookBtn
            // 
            this.addBookBtn.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.Location = new System.Drawing.Point(880, 425);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(164, 49);
            this.addBookBtn.TabIndex = 0;
            this.addBookBtn.Text = "کتاب جدید";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // deletBookBtn
            // 
            this.deletBookBtn.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletBookBtn.Location = new System.Drawing.Point(678, 425);
            this.deletBookBtn.Name = "deletBookBtn";
            this.deletBookBtn.Size = new System.Drawing.Size(164, 49);
            this.deletBookBtn.TabIndex = 1;
            this.deletBookBtn.Text = "حذف";
            this.deletBookBtn.UseVisualStyleBackColor = true;
            this.deletBookBtn.Click += new System.EventHandler(this.deletBookBtn_Click);
            // 
            // editBookBtn
            // 
            this.editBookBtn.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookBtn.Location = new System.Drawing.Point(880, 498);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Size = new System.Drawing.Size(164, 49);
            this.editBookBtn.TabIndex = 2;
            this.editBookBtn.Text = "ویرایش";
            this.editBookBtn.UseVisualStyleBackColor = true;
            this.editBookBtn.Click += new System.EventHandler(this.editBookBtn_Click);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(678, 498);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(164, 49);
            this.category.TabIndex = 4;
            this.category.Text = "دسته بندی";
            this.category.UseVisualStyleBackColor = true;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // dtabook
            // 
            this.dtabook.AllowUserToAddRows = false;
            this.dtabook.AllowUserToDeleteRows = false;
            this.dtabook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtabook.Location = new System.Drawing.Point(31, 86);
            this.dtabook.Name = "dtabook";
            this.dtabook.ReadOnly = true;
            this.dtabook.RowHeadersWidth = 51;
            this.dtabook.RowTemplate.Height = 24;
            this.dtabook.Size = new System.Drawing.Size(618, 529);
            this.dtabook.TabIndex = 5;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(678, 572);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(366, 43);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "بروزرسانی";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(357, 35);
            this.searchInput.Multiline = true;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(292, 32);
            this.searchInput.TabIndex = 10;
            this.searchInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(197, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(103, 32);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "نام کتاب";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(31, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(130, 32);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "نام نویسنده";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(678, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.Size = new System.Drawing.Size(366, 356);
            this.treeView1.TabIndex = 13;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1086, 673);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dtabook);
            this.Controls.Add(this.category);
            this.Controls.Add(this.editBookBtn);
            this.Controls.Add(this.deletBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "FrmMain";
            this.Text = "BoxBook";
            this.Load += new System.EventHandler(this.Formbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtabook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button deletBookBtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.DataGridView dtabook;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TreeView treeView1;
    }
}