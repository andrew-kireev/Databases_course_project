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
    public partial class Client_credit : Form
    {
        public Client_credit()
        {
            InitializeComponent();
        }

        private void creditBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.creditBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void Client_credit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.bankDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Credit". При необходимости она может быть перемещена или удалена.
            this.creditTableAdapter.Fill(this.bankDataSet.Credit);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFormlClient f4 = new MainFormlClient();
            f4.ShowDialog();
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
