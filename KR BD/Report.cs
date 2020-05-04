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
    public partial class Report : Form
    {
        public Report()
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
            ReportBank f4 = new ReportBank();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f4 = new Form2();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportCredit f4 = new ReportCredit();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportDeposit f4 = new ReportDeposit();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportCards f4 = new ReportCards();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportCreditType f4 = new ReportCreditType();
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportEmploee f4 = new ReportEmploee();
            f4.ShowDialog();
        }
    }
}
