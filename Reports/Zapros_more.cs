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
    public partial class Zapros_more : Form
    {
        public Zapros_more()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void Zapros_more_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.bankDataSet.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {   /*
            var Zapros_more = new Zapros_more();
            Zapros_more.Requested("select Clients.FullName from Clients inner join Deposit On Deposit.Amount > 450000");
            */
        }
    }
}
