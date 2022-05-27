using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailKit.Net;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Mime;

namespace Nhom07_Lap5
{
    public partial class Bai1_SendMail : Form
    {
        public Bai1_SendMail()
        {
            InitializeComponent();
        }

        MimeMessage message = new MimeMessage();
        private void bt_Login_Click(object sender, EventArgs e)
        {
            MailboxAddress mailboxAddress;
            if (MailboxAddress.TryParse(tb_From.Text, out mailboxAddress) && MailboxAddress.TryParse(tb_To.Text, out mailboxAddress)
                && tb_From.Text.Contains("@") && tb_To.Text.Contains("@"))
            {

            }
            else
            {
                MessageBox.Show("Không đúng định dạnh mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }


            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", tb_From.Text));
            message.To.Add(new MailboxAddress("", tb_To.Text));

            if (tb_Subject.Text == "" || tb_Body.Text == "")
            {
                MessageBox.Show("Subject và Body mai bị trống", "Thông báo");
                return;
            }

            message.Subject = tb_Subject.Text;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = tb_Body.Text;
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    client.Connect("smtp.gmail.com", 587, false);
                }
                catch (Exception ConnectFailed)
                {
                    MessageBox.Show("Không thể kết nối đến server");
                    return;
                }

                if (tb_PassWord.Text == "")
                {
                    MessageBox.Show("Password is empty!");
                    return;
                }
                else
                    try
                    {
                        client.Authenticate(tb_From.Text, tb_PassWord.Text);
                    }
                    catch (Exception IncorrectAccount)
                    {
                        MessageBox.Show("Xác thực không chính xác, đăng nhập lại ", "Thông báo");
                        return;
                    }


                try
                {
                    client.Send(message);
                    client.Disconnect(true);
                    MessageBox.Show("Gửi mail tới " + tb_To + " thành công!");
                }
                catch (Exception OutOfMemory)
                {
                    MessageBox.Show("Exception OutOfMemory" + OutOfMemory);
                    return;
                }
            }
        }
    }
}
