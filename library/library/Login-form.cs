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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
        panelMain frm = new panelMain();
            if (username.Text == Properties.Settings.Default.Username )
            {
                if (password.Text == Properties.Settings.Default.Password)
                {
                    frm.Show();
                   this.Hide();
                }


            }
            else
            {
              
                MessageBox.Show("نام کاربری و رمزعبور اشتباه است");
            }
        }

    }
}
