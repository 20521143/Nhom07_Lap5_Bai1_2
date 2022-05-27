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
    public partial class XemMail : Form
    {
        public XemMail()
        {
            InitializeComponent();
        }
        public void readHtmlMail(string data)
        {
            webBrowser1.DocumentText = data;
        }
    }
}
