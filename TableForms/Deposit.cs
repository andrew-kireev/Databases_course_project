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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void depositBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.depositBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Deposit". При необходимости она может быть перемещена или удалена.
            this.depositTableAdapter.Fill(this.bankDataSet.Deposit);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDeposit f4 = new ReportDeposit();
            f4.ShowDialog();
        }
    }
}
