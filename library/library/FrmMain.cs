using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class panelMain : Form
    {
        public panelMain()
        {
            InitializeComponent();
        }

        private void books_Click(object sender, EventArgs e)
        {
            FrmMain book = new FrmMain();
            book.ShowDialog();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            frmuser frmuser = new frmuser();
            frmuser.Text = "Users";
            frmuser.ShowDialog();
        }

        private void trust_Click(object sender, EventArgs e)
        {
            frmdepository fd = new frmdepository();
            fd.ShowDialog();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            frmSetting frmset = new frmSetting();
            frmset.ShowDialog();
        }

        private void mangAcc_Click(object sender, EventArgs e)
        {
            frmnote manageAcc = new frmnote();
            manageAcc.ShowDialog();
        }
        DataBase db = new DataBase();
     

        private void panelMain_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select tbl_depository.id, tbl_depository.idbook,tbl_depository.idborrower , tbl_book.name , tbl_user.fname , tbl_user.lname from tbl_book inner join tbl_depository on tbl_depository.idbook=tbl_book.id inner join tbl_user on tbl_user.id=tbl_depository.idborrower");
            dataGridView1.DataSource = dt;
       
    
            string s = "";
            PersianCalendar pc = new PersianCalendar();
            string now = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s = dt.Rows[i].ItemArray[2].ToString();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain_Load(sender, e);
        }
    }
}

    
