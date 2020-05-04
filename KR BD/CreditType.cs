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
    public partial class CreditType : Form
    {
        public CreditType()
        {
            InitializeComponent();
        }

        private void typeCreditBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeCreditBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void CreditType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.TypeCredit". При необходимости она может быть перемещена или удалена.
            this.typeCreditTableAdapter.Fill(this.bankDataSet.TypeCredit);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportCreditType f4 = new ReportCreditType();
            f4.ShowDialog();
        }
    }
}
