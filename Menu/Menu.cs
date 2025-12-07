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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Bai2.Form1 tmp = new Bai2.Form1();
            tmp.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Bai5.LoginForm tmp = new Bai5.LoginForm();
            tmp.Show();
        }
    }
}
