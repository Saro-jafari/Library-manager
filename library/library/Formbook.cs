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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


   
        private void category_Click(object sender, EventArgs e)
        {   
            booktypecs booktypecs = new booktypecs();
            booktypecs.ShowDialog();

        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            FormAddbookcs book = new FormAddbookcs();
            book.Text = "Add";
         
            book.ShowDialog();
       
        }
        DataBase db = new DataBase();
        private void Formbook_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            dt = db.Select("select tbl_book.id,tbl_book.name,tbl_book.writer,tbl_type.type from tbl_book inner join tbl_type on tbl_book.type = tbl_type.id ");
            dtabook.DataSource = dt;
            //--------------------------------------------------------------

            dt2 = db.Select("select * from tbl_type");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                treeView1.Nodes.Add(dt2.Rows[i].ItemArray[1].ToString());
            }

            //---------------------------------------------------
            dt2.Reset();

            int id = 0;
            dt2 = db.Select("select * from tbl_book");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                id = (int)dt2.Rows[i].ItemArray[3];
           //     treeView1.Nodes[id].Nodes.Add(dt2.Rows[i].ItemArray[1].ToString());

            }
        }
        private void deletBookBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int id;
            id = int.Parse(dtabook.CurrentRow.Cells[0].Value.ToString());
            
            

            dt = db.Select("select * from tbl_depository where idbook = " + id);
           if (dt.Rows.Count == 0) {
                if (db.Exe("delete from tbl_book where id = " + id) == true)
                {
                    Formbook_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("کتاب مورد نظر در امانت است ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            FormAddbookcs frmbookedit = new FormAddbookcs();
            frmbookedit.Text = "Edit";
            frmbookedit.textBox1.Text = dtabook.CurrentRow.Cells[1].Value.ToString();
            frmbookedit.textBox2.Text = dtabook.CurrentRow.Cells[2].Value.ToString();
            frmbookedit.textBox3.Text = dtabook.CurrentRow.Cells[0].Value.ToString();

            frmbookedit.ShowDialog();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Formbook_Load(sender, e);
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string strf = "";
          if(radioButton1.Checked == true) strf = "name";
            if (radioButton2.Checked == true) strf = "writer";
              
       dt = db.Select("select tbl_book.id,tbl_book.name,tbl_book.writer,tbl_type.type from tbl_book inner join tbl_type on tbl_book.type = tbl_type.id and " + strf + " like '%' + N'" + searchInput.Text + "' + '%'");
            dtabook.DataSource = dt;
        }
    }
}
