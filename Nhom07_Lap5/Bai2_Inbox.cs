using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace Nhom07_Lap5
{
    public partial class Bai2_Inbox : Form
    {
        public Bai2_Inbox()
        {
            InitializeComponent();
            LoadListView();
        }
        //Tạo danh sách các mail nhận về
        List<MimeMessage> listMail = new List<MimeMessage>();
        void LoadListView()
        {
            //Thiết kế giao diện
            listView1.Clear();
            listView1.Columns.Add("Email", 200);
 
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Thời gian", 200);
            listView1.View = View.Details;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Login.Enabled = false;
                using (var client = new ImapClient())
                {
                    if (tb_Email.Text == string.Empty ||tb_PassWord.Text == string.Empty)
                    {
                        MessageBox.Show("email và password không được để trống", "Thông báo");
                        btn_Login.Enabled = true;
                        return;

                    }
                    else
                    {
                        try
                        {
                            client.Connect("imap.gmail.com", 993, true);
                            client.Authenticate(tb_Email.Text, tb_PassWord.Text);
                            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Login.Enabled = true;
                            return;
                        }



                        var message = client.Inbox;
                        message.Open(FolderAccess.ReadOnly);
                        int countMessage = message.Count();
                        label_Total.Text = message.Count().ToString();
                        countMessage = (countMessage > 10) ? 10 : countMessage;
                        
                        label_Recent.Text = countMessage.ToString();

                        for (int i = 0; i < countMessage; i++)
                        {

                            var item = message.GetMessage(i);
                            ListViewItem email = new ListViewItem(item.Subject);
                            ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(email, item.From.ToString());
                            email.SubItems.Add(from);
                            ListViewItem.ListViewSubItem thoiGian = new ListViewItem.ListViewSubItem(email, item.Date.ToString());
                            email.SubItems.Add(thoiGian);

                            listView1.Items.Add(email);

                            listMail.Add(item);
                            listView1.AutoArrange = true;


                        }
                    }
                };

            }
            catch
            {
                MessageBox.Show("Lỗi chứng thực tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Login.Enabled = true;
            };
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {

                int thuTu;
                thuTu = listView1.SelectedItems[0].Index;
                var mess = listMail[thuTu].HtmlBody;
                XemMail xmail = new XemMail();
                xmail.readHtmlMail(mess);
                xmail.Show();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tb_PassWord.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Email.UseSystemPasswordChar = true;
            }
        }
    }
}
