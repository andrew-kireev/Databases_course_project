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
    public partial class Client_deposit : Form
    {
        public Client_deposit()
        {
            InitializeComponent();
        }

        private void depositBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.depositBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void Client_deposit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Deposit". При необходимости она может быть перемещена или удалена.
            this.depositTableAdapter.Fill(this.bankDataSet.Deposit);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFormlClient f4 = new MainFormlClient();
            f4.ShowDialog();
        }
    }
}
