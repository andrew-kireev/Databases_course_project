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
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }

        private void cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDataSet);

        }

        private void Cards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Card". При необходимости она может быть перемещена или удалена.
            this.cardTableAdapter.Fill(this.bankDataSet.Card);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportCards f4 = new ReportCards();
            f4.ShowDialog();
        }
    }
}
