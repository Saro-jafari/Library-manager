using library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmnote : Form
    {
        public frmnote()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void frmnote_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select tbl_depository.id, tbl_depository.idbook,tbl_depository.idborrower , tbl_book.name , tbl_user.fname , tbl_user.lname from tbl_book inner join tbl_depository on tbl_depository.idbook=tbl_book.id inner join tbl_user on tbl_user.id=tbl_depository.idborrower");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                db.Exe("delete from tbl_depository where id = " + int.Parse(txtid.Text));
                frmnote_Load(sender, e);
                txtid.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtsearch.Text != "")
                {
                    string str = "";
                    if (radioButton1.Checked)
                        str = "tbl_book.id";
                    else if (radioButton2.Checked)
                        str = "tbl_user.id";
                    DataTable dt = new DataTable();
                    dt = db.Select("select tbl_depository.id, tbl_depository.idbook,tbl_depository.idborrower , tbl_book.name , tbl_user.fname , tbl_user.lname from tbl_book inner join tbl_depository on tbl_depository.idbook=tbl_book.id inner join tbl_user on tbl_user.id=tbl_depository.idborrower and " + str + "=" + txtsearch.Text);
                    if (dt.Rows.Count == 0)
                        MessageBox.Show("عبارت مورد نظر یافت نشد", "False", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dataGridView1.DataSource = dt;
                }
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmnote_Load(sender, e);
        }

     
    }
}
