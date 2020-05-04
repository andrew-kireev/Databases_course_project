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
    public partial class MainFormlClient : Form
    {
        public MainFormlClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Client_client f4 = new Client_client();
            f4.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Client_credit f4 = new Client_credit();
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Client_deposit f4 = new Client_deposit();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Client_card f4 = new Client_card();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Авторизация f4 = new Авторизация();
            f4.ShowDialog();
        }
    }
}
