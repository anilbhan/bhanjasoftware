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
    public partial class Staffdetails : Form
    {
        public Staffdetails()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {


            string query = "insert into bps.staffdetails(name,address,phonenumber,salary,joineddate)values('" + name_text.Text + "','" + address_text.Text + "','" + phonenumber_txtbox.Text + "','" + slry_txtbox.Text + "','" + date_txtbox.Text + "');";
            Function.ConnectDB();
            MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                reader.Close();
                //for going from one tab to another after data saved
                tabControl1.SelectedTab = tabPage2;
                //fill the datagridview again of old customer
                Function.FillDataGridViewStaffDetails(dataGridView1);

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void phonenumber_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {

        }

        void EnableRegisterButton()
        {
            if (string.IsNullOrEmpty(name_text.Text) ||
                string.IsNullOrEmpty(address_text.Text) ||
                string.IsNullOrEmpty(phonenumber_txtbox.Text) ||
                string.IsNullOrEmpty(slry_txtbox.Text) ||
                string.IsNullOrEmpty(date_txtbox.Text))
            {
                save_btn.Enabled = false;
            }
            else
            {
                save_btn.Enabled = true;
            }
        }

        private void Staffdetails_Load(object sender, EventArgs e)
        {
            EnableRegisterButton();
            Function.ConnectDB();
            Function.FillDataGridViewStaffDetails(dataGridView1);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            name_text.Clear();
            phonenumber_txtbox.Clear();
            slry_txtbox.Clear();
            address_text.Clear();
        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            Function.Search(dataGridView1, search_txtbox);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void date_txtbox_TextChanged(object sender, EventArgs e)
        {
            EnableRegisterButton();
        }

        private void export_btnexcel_Click(object sender, EventArgs e)
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

        private void export_btnpdf_Click(object sender, EventArgs e)
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

        private void print_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
      
    }
}
