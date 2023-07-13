namespace library
{
    partial class booktypecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booktypecs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addType = new System.Windows.Forms.Button();
            this.deleteType = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // addType
            // 
            this.addType.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addType.Location = new System.Drawing.Point(661, 350);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(127, 40);
            this.addType.TabIndex = 1;
            this.addType.Text = "اضافه کردن";
            this.addType.UseVisualStyleBackColor = true;
            this.addType.Click += new System.EventHandler(this.addType_Click);
            // 
            // deleteType
            // 
            this.deleteType.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteType.Location = new System.Drawing.Point(269, 350);
            this.deleteType.Name = "deleteType";
            this.deleteType.Size = new System.Drawing.Size(127, 40);
            this.deleteType.TabIndex = 2;
            this.deleteType.Text = "حذف";
            this.deleteType.UseVisualStyleBackColor = true;
            this.deleteType.Click += new System.EventHandler(this.deleteType_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 350);
            this.textBox1.MinimumSize = new System.Drawing.Size(100, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 40);
            this.textBox1.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(426, 350);
            this.txtName.MinimumSize = new System.Drawing.Size(100, 40);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 40);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // booktypecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(814, 462);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteType);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "booktypecs";
            this.Text = "booktypecs";
            this.Load += new System.EventHandler(this.booktypecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addType;
        private System.Windows.Forms.Button deleteType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtName;
    }
}