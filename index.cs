using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BhanjaPoultrySuppliers
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void newCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newcustomer f3 = new newcustomer();
            f3.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void chicksSupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form chi = new chicks();
            chi.Show();
        }

        private void broilersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ds = new DailySell();
            ds.Show();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pd = new Paymentdetails();
            pd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form staff = new Staffdetails();
            staff.Show();
        }

        private void StaffRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cashCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cashcol = new cashcollection();
            cashcol.Show();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form backup = new BackupForm();
            backup.Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form restore = new RestoreForm();
            restore.Show();
        }

        private void layersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form buysproduct = new buys();
            buysproduct.Show();
        }

        private void cashDepositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cashdep = new cashdeposite();
            cashdep.Show();
        }

       

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new aboutus();
            about.Show();

        }
    }
}
