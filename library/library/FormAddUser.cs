using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace library
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        bool temp = false;

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            strfileName = txtlname.Text + txtlname.Text + telTxt.Text;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select...";
            ofd.Filter = " JPG (*.JPG)|*.JPG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                temp = true;
            }
        }






        DataBase db = new DataBase();
        string strfileName = "";
        private void submitAddUser_Click(object sender, EventArgs e)
        {
            string filename = txtname.Text + txtlname.Text + telTxt.Text;
            string path = "F:\\#C\\main-project\\ImageUserLibrary\\" + filename + ".jpg";
            if (Text == "Add")
            {
                if (temp)
                    pictureBox1.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);

                else
                    path = "F:\\#C\\main-project\\ImageUserLibrary\\User.jpg";
                if (db.Exe("insert into tbl_user(fname,lname,tel,pic) values (N'" + txtname.Text + "',N'" + txtlname.Text + "',N'" + telTxt.Text + "',N'" + path + "')") == true)
                {
                    txtname.Text = txtlname.Text = telTxt.Text = "";
                    pictureBox1.ImageLocation = "F:\\#C\\main-project\\ImageUserLibrary\\User.jpg";
                    temp = false;
                   
                }
            }
            else if (Text == "Edit")

                System.IO.File.Delete("F:\\#C\\main-project\\ImageUserLibrary\\" + strfileName + ".jpg");
            pictureBox1.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            if (db.Exe("update tbl_user set fname= N'" + txtname.Text + "',lname= N'" + txtlname.Text + "',tel= N'" + telTxt.Text + "' ,pic=N'" + path + "' where id = " + idTxtBox.Text) == true)
            {
                txtname.Text = txtlname.Text = telTxt.Text = "";
                pictureBox1.ImageLocation = "F:\\#C\\main-project\\ImageUserLibrary\\User.jpg";
            }
        }

    }
}    
    
    


