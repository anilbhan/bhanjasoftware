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
    public partial class RestoreForm : Form
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "*.sql|*.sql|*.*|*.*";
            if (DialogResult.OK == f.ShowDialog())
            {
                textBox1.Text = f.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;pwd=;database=bps;"; // <- what to backup
            string filename = textBox1.Text;

            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Please select the SQL file first!");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand();
                MySqlBackup mb = new MySqlBackup(cmd);
                try
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ImportFromFile(filename); // <- main restore command
                    MessageBox.Show("Database Imported Successfully!!", "Imported", MessageBoxButtons.OK,
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
