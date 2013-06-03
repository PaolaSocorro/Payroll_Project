using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project4
{
    public partial class TestForm : StandardForm
    {

        public TestForm()
        {
            InitializeComponent();
        }

        private void master_TransactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.master_TransactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project4dataDataSet);

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project4dataDataSet.Jan_Transactions' table. You can move, or remove it, as needed.
            this.jan_TransactionsTableAdapter.Fill(this.project4dataDataSet.Jan_Transactions);
            // TODO: This line of code loads data into the 'project4dataDataSet.Master_Transactions' table. You can move, or remove it, as needed.
            this.master_TransactionsTableAdapter.Fill(this.project4dataDataSet.Master_Transactions);

        }

        
    }
}
