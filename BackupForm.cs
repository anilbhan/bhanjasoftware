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
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "*.sql|*.sql|*.*|*.*";
            //f.FileName = "PMS-Dump_" + DateTime.Now.ToString("yyyy-MM-dd") + ".sql";
            if (DialogResult.OK == f.ShowDialog())
            {
                textBox1.Text = f.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select the location of the file first!");
            }
            else
            {

                //code for backing up MySQL database  using open source MySQLBackup library

                string connectionString = "server=localhost;user=root;pwd=;database=bps;Convert Zero DateTime = true;"; // <- what to backup
                string filename = textBox1.Text;
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand();
                MySqlBackup mb = new MySqlBackup(cmd);
                try
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ExportToFile(filename); // <- main backup command
                    MessageBox.Show("Database Backed Up Successfully!!", "Backed Up", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }      
         
        }
    }
}
