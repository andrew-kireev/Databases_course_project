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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Авторизация f4 = new Авторизация();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank f4 = new Bank();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f4 = new Form1();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Credit f4 = new Credit();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deposit f4 = new Deposit();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cards f4 = new Cards();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreditType f4 = new CreditType();
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Emploee f4 = new Emploee();
            f4.ShowDialog();
        }
    }
}
