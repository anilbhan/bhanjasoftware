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
    public partial class Paymentdetails : Form
    {
        public Paymentdetails()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string query = "insert into bps.dailyexpenses(name,details,amount,date)values('" + name_textbox.Text + "','" +expenses_textbox.Text + "','" + amount_textbox.Text + "', '" + date_lbl.Text+ "');";
            Function.ConnectDB();
            MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                reader.Close();
                name_textbox.Clear();
                amount_textbox.Clear();
                expenses_textbox.Clear();
                date_lbl.Text = "";
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Paymentdetails_Load(object sender, EventArgs e)
        {
            date_lbl.Text = Function.date;
            Function.ConnectDB();
            Function.FillDataGridViewdailyexpenses(dataGridView1);
        }

        private void exportpdf_btn_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF Documents (*.pdf)|*.pdf";
                sfd.FileName = "Export_Data.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Function.GeneratePdf(dataGridView1, sfd);
                    MessageBox.Show("Data Successfully Exported as PDF File", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void exportexcel_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Export_Data.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Function.GenerateExcel(dataGridView1, sfd.FileName);
                MessageBox.Show("Data Successfully Exported as Excel File", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     

       

       

      
    }
}
