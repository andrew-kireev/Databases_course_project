﻿using System;
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
    public partial class ReportCards : Form
    {
        public ReportCards()
        {
            InitializeComponent();
        }

        private void ReportCards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BankDataSet.Card". При необходимости она может быть перемещена или удалена.
            this.CardTableAdapter.Fill(this.BankDataSet.Card);

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report f4 = new Report();
            f4.ShowDialog();
        }
    }
}
