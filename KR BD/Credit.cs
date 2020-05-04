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
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }

        private void creditBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.creditBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void Credit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.TypeCredit". При необходимости она может быть перемещена или удалена.
            this.typeCreditTableAdapter.Fill(this.bankDataSet.TypeCredit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.TypeCredit". При необходимости она может быть перемещена или удалена.
            this.typeCreditTableAdapter.Fill(this.bankDataSet.TypeCredit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.TypeCredit". При необходимости она может быть перемещена или удалена.
            this.typeCreditTableAdapter.Fill(this.bankDataSet.TypeCredit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Credit". При необходимости она может быть перемещена или удалена.
            this.creditTableAdapter.Fill(this.bankDataSet.Credit);

        }

        private void idCreditTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportCredit f4 = new ReportCredit();
            f4.ShowDialog();
        }
    }
}
