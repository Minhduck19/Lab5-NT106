using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Bai1.Form1 bai1Form = new Bai1.Form1();
            bai1Form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Bai4.Form1 bai4Form = new Bai4.Form1(); 
            bai4Form.Show();
        }
    }
}
