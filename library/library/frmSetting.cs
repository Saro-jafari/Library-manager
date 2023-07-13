using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using library;
using System.Globalization;

namespace Library
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lpass =library.Properties.Settings.Default.Password;
            if (txtlp.Text == lpass)
            {
                library.Properties.Settings.Default.Password = txtnp.Text;
                 library.Properties.Settings.Default.Save();
                txtlp.Text = txtnp.Text = "";
            }
        }
        DataBase db = new DataBase();
        public bool SendMail(string strmail, string path)
        {
            try
            {
                MailMessage mm;
                MailAddress from = new MailAddress("Sarojafari2004@gmail.com","فایل پشتیبان",Encoding.Unicode);
                MailAddress to = new MailAddress(strmail);
                mm = new MailMessage(from, to);
                mm.Subject = "Backup From DataBase";
                mm.Body = DateTime.Now.ToShortDateString() + Environment.NewLine + DateTime.Now.ToShortTimeString();
                Attachment a = new Attachment(path, MediaTypeNames.Application.Octet);
                mm.Attachments.Add(a);
                SmtpClient smtpc = new SmtpClient();
                smtpc.Port = 587;
                smtpc.EnableSsl = true;
                smtpc.Host = "smtp.gmail.com";
                string pasgm = "@Samyar2020";
                smtpc.Credentials = new NetworkCredential("Sarojafari2004@gmail.com", pasgm);
                smtpc.Send(mm);
                return true;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return false;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save...";
            sfd.Filter = "Back File (*.bak)|*.bak";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (db.Exe("backup database library to disk ='" + sfd.FileName + "'"))
                {
                    
                    MessageBox.Show(".پشتیبان گیری یا موفقیت انجام شد", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    library.Properties.Settings.Default.lastbackup = DateTime.Now.ToShortDateString();
                    library.Properties.Settings.Default.Save();
                    if (MessageBox.Show("آیا میل دارید که فایل پشتیبان به پست الکترونیکی شما ارسال شود ؟", "True", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (SendMail(library.Properties.Settings.Default.mail, sfd.FileName) == true)
                            MessageBox.Show(".فایل پشتیبان با موفقیت ارسال شد", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(".فایل پشتیبان با موفقیت ارسال نشد", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(".پشتیبان گیری یا موفقیت انجام نشد", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Load(object sender, EventArgs e)
        {
            txtlb.Text = library.Properties.Settings.Default.lastbackup;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Open...";
            op.Filter = "Buckup File (*.bak)|*.bak";
            if (op.ShowDialog() == DialogResult.OK)
            {
                if (db.Exe("alter database library set single_user with rollback immediate use master restore database library from disk = '" + op.FileName + "' with replace"))
                    MessageBox.Show(".بازگردانی یا موفقیت انجام شد", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(".بازگردانی یا موفقیت انجام نشد", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            library.Properties.Settings.Default.mail = txtmail.Text;
                library.Properties.Settings.Default.Save();
      
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
