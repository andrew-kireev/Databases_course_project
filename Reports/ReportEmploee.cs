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
    public partial class ReportEmploee : Form
    {
        public ReportEmploee()
        {
            InitializeComponent();
        }

        private void ReportEmploee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BankDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.EmployeesTableAdapter.Fill(this.BankDataSet.Employees);

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report f4 = new Report();
            f4.ShowDialog();
        }
    }
}
