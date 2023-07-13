using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class booktypecs : Form
    {
        public booktypecs()
        {
            InitializeComponent();
        }

    
        DataBase db = new DataBase();
        private void addType_Click(object sender, EventArgs e)
        {
           if( db.Exe("insert tbl_type(type) values (N'" + txtName.Text + "')")==true)
            {
                txtName.Text = "";
                booktypecs_Load(sender,e);
                
               
            }
           
        }
        private void booktypecs_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
         dt= db.Select("select * from tbl_type");
            dataGridView1.DataSource = dt;
        }

           

        private void deleteType_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select * from tbl_book where type=" + textBox1.Text);
            if (dt.Rows.Count == 0)
            {
                if (db.Exe("delete from tbl_type where id =" + textBox1.Text))
                {
                    booktypecs_Load(sender, e);
                    textBox1.Text = "";

                }
            }
            else
                MessageBox.Show(".دسته ای مورد نظر قابل حذف نیست", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
           textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
    }
