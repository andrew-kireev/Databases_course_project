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
    public partial class Client_card : Form
    {
        public Client_card()
        {
            InitializeComponent();
        }

        private void cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void Client_card_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.bankDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Card". При необходимости она может быть перемещена или удалена.
            this.cardTableAdapter.Fill(this.bankDataSet.Card);

        }
    }
}
