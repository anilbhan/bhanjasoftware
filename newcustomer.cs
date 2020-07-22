using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinFormCharpWebCam;
using System.Drawing.Printing;

namespace BhanjaPoultrySuppliers
{
    public partial class newcustomer : Form
    {
        public newcustomer()
        {
            InitializeComponent();

           
        }

        
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //method to check each and every control whether it is 
        //empty or not 
        void EnableRegisterButton()
        {
            if (string.IsNullOrEmpty(name_text.Text) ||
                string.IsNullOrEmpty(address_text.Text) || string.IsNullOrEmpty(phn_num.Text))
              
            {
                save_btn.Enabled = false;
            }
            else
            {
                save_btn.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //clearing all the textboxes
            name_text.Clear();
            address_text.Clear();
            phn_num.Clear();
            textBox4.Clear();
            
        }

      

        void EnableRegisterButton1()
        {
            if (string.IsNullOrEmpty(name_text.Text) ||
                string.IsNullOrEmpty(address_text.Text) ||
                string.IsNullOrEmpty(phn_num.Text))
                
            {
                save_btn.Enabled = false;
            }
            else
            {
                save_btn.Enabled = true;
            }
        }

        private void phn_num_TextChanged(object sender, EventArgs e)
        {
            EnableRegisterButton();
        }



        private void newcustomer_Load_1(object sender, EventArgs e)
        {
            

            Function.ConnectDB();
            Function.FillDataGridView(dataGridView1);

            EnableRegisterButton();


        }

        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Function.Search(dataGridView1, textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            //printout code
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(PrintImage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //capturing the form and draw a bitmap
        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string MyConnection = "datasource=localhost;port=3306;username=root;password=";
            string query = "insert into bps.newcustomer(name,address,phonenumber,deposit)values('" + name_text.Text + "','" + address_text.Text + "','" + phn_num.Text + "','" + textBox4.Text + "');";
            MySqlConnection myconn = new MySqlConnection(MyConnection);
            MySqlCommand cmd = new MySqlCommand(query, myconn);
            MySqlDataReader reader;
            try
            {
                myconn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
               

                //fill the datagridview again of old customer
                Function.FillDataGridView(dataGridView1);

                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            name_text.Clear();
            phn_num.Clear();
            address_text.Clear();
            textBox4.Clear();
          
        }

        private void phn_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void phn_num_TextChanged_1(object sender, EventArgs e)
        {
            EnableRegisterButton();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string MyConnection = "datasource=localhost;port=3306;username=root;password=";
            string query = "Delete from bps.newcustomer where id='"+ dataGridView1.CurrentRow.Cells["id"].Value.ToString() +"'";
            MySqlConnection myconn = new MySqlConnection(MyConnection);
            MySqlCommand cmd = new MySqlCommand(query, myconn);
            MySqlDataReader reader;
            try
            {
                myconn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been deleted sucessfully");
                Function.FillDataGridView(dataGridView1);  

                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}