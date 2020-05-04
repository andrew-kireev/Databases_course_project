using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_BD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form5 f4 = new Form5();
            f4.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Insert f4 = new Insert();
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Report f4 = new Report();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Авторизация f4 = new Авторизация();
            f4.ShowDialog();
        }
    }
}
