using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using library;

namespace Library
{
    public partial class frmdepository : Form
    {
        public frmdepository()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();




        private void txtuserid_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select id from tbl_user where id =" + int.Parse(txtuserid.Text));
            if (dt.Rows.Count == 1)
                txtuserid.BackColor = Color.GreenYellow;
            else if (dt.Rows.Count == 0)
                txtuserid.BackColor = Color.Red;
        }






        private void button1_Click_1(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            txtnow.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void txtbookid_Leave(object sender, EventArgs e)
        {
            
          
                DataTable dt = new DataTable();
                dt = db.Select("select id from tbl_book where id = " + int.Parse(txtbookid.Text));
                if (dt.Rows.Count == 1)
                    txtbookid.BackColor = Color.GreenYellow;
                else if (dt.Rows.Count == 0)
                    txtbookid.BackColor = Color.Red;
            

        }

        private void txtuserid_Leave_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select id from tbl_user where id =" + int.Parse(txtuserid.Text));
            if (dt.Rows.Count == 1)
                txtuserid.BackColor = Color.GreenYellow;
            else if (dt.Rows.Count == 0)
                txtuserid.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnow.Text != "")
            {
                PersianCalendar pc = new PersianCalendar();
                DateTime dt = DateTime.Now;
                string[] str = txtnow.Text.Split('/');
                if (int.Parse(str[2]) + 10 > 30)
                    txtdate.Text = pc.GetYear(dt).ToString() + "/" + pc.GetMonth(dt.AddMonths(1)).ToString() + "/" + pc.GetDayOfMonth(dt.AddDays(10)).ToString();
                else
                    txtdate.Text = pc.GetYear(dt).ToString() + "/" + pc.GetMonth(dt).ToString() + "/" + pc.GetDayOfMonth(dt.AddDays(10)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtbookid.BackColor == Color.GreenYellow && txtuserid.BackColor == Color.GreenYellow) && (txtnow.Text != "" && txtdate.Text != ""))
            {
                if (db.Exe("insert into tbl_depository(idbook,idborrower,date,maxdate) values ('" + int.Parse(txtbookid.Text) + "','" + int.Parse(txtuserid.Text) + "','" + txtnow.Text + "','" + txtdate.Text + "')") == true)
                {
                    txtbookid.Text = txtuserid.Text = txtnow.Text = txtdate.Text = "";
                    txtbookid.BackColor = txtuserid.BackColor = Color.White;
           

                }
            } 
        }
    }
    }
