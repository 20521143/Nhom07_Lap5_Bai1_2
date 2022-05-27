using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom07_Lap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2_Inbox bb = new Bai2_Inbox();
            bb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bai1_SendMail bb = new Bai1_SendMail();
            bb.Show();
        }
    }
}
