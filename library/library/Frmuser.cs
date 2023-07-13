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
    public partial class frmuser : Form
    {
        public frmuser()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.Text = "Add";
            formAddUser.ShowDialog();

        }

        private void frmuser_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select id,fname,lname,tel from tbl_user");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = db.Select("select pic from tbl_user where id =" + id);
            string filename = dt.Rows[0].ItemArray[0].ToString();
            pictureBox1.ImageLocation = filename;
        }


        private void deletePic_Click(object sender, EventArgs e)
        {
            /*    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (db.Exe("delete * from tbl_user where id=" + id) == true)
                {
                    frmuser_Load(sender, e);

                    pictureBox1.ImageLocation = "";
                }
            */
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = db.Select("select * from tbl_depository where idborrower=" + id);
            if (dt.Rows.Count == 0)
            {
                dt = db.Select("select * from tbl_user where id=" + id);
                string name;
                name = dt.Rows[0].ItemArray[1].ToString();
                name += dt.Rows[0].ItemArray[2].ToString();
                name += dt.Rows[0].ItemArray[3].ToString();
                if (db.Exe("delete from tbl_user where id=" + id) == true)
                {
                    frmuser_Load(sender, e);
                    pictureBox1.ImageLocation = "";
                    System.IO.File.Delete("F:\\#C\\main-project\\ImageUserLibrary\\" + name + ".jpg");
                }
            }
            else
                MessageBox.Show(".کاربر مورد نظر بدهکار است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    

    }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.Text = "Edit";
            formAddUser.txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();  
            formAddUser.txtlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            formAddUser.idTxtBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            formAddUser.telTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            formAddUser.pictureBox1.Image = pictureBox1.Image;
            formAddUser.ShowDialog();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            string strname = "";
            if (radioButton1.Checked)
            {
                strname = "fname";
            }else if (radioButton2.Checked)
            {
                strname = "lname";

            }else if (radioButton3.Checked)
            {
                strname = "id";
            }
            DataTable dt = new DataTable();
          dt=  db.Select("select id,fname,lname,tel from tbl_user where "+strname+" like '%'+ N'"+txtsearch.Text+ "'+'%'");
     dataGridView1.DataSource = dt;
        }

      
    }
}