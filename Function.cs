using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Security.Cryptography;

namespace BhanjaPoultrySuppliers
{
    class Function
    {
        public const string MyConnection = "datasource=localhost;port=3306;username=root;password=;Convert Zero DateTime= true";
        public static DataTable DbDataTable;
        public static MySqlConnection MyCon;
        
        public static string date = DateTime.Now.ToString("yyyy-MM-dd");
        public static string aMonthAgo = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
        public static void ConnectDB()
        {
            try
            {
                MyCon = new MySqlConnection(MyConnection);
                MyCon.Open();
            }
            catch (Exception ex) { 
            
            
            }

        }

        //method that generates a MD5 HASH of the given text
        public static string Md5HashGenerator(TextBox txt)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();

            //converting bytes to string
            var hash = BitConverter.ToString(md5.ComputeHash(utf8.GetBytes(txt.Text))).ToLower().Replace("-", "");
            return hash;
        }

        public static void FillDataGridView(DataGridView a)
        {
            a.RowHeadersVisible = false;
            string query = "select id,name,address,phonenumber,deposit,previousamount from bps.newcustomer;";
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FillDataGridViewStaffDetails(DataGridView a)
        {
            a.RowHeadersVisible = false;
            string query = "select id,name,address,phonenumber,salary,joineddate from bps.staffdetails;";
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FillDataGridViewExpenses(DataGridView a)
        {
            a.RowHeadersVisible = false;
            string query = "select SUM(buyschicksform.total) as 'Buying Chicks', SUM(buysfeedform.total) as 'Buying Feeds',SUM(buysnameform.total) as 'Chicks Types', SUM(dailyexpenses.amount) as 'Daily Expenses' from bps.buyschicksform WHERE (date BETWEEN '" + aMonthAgo + "' AND '" + date + "'), bps.buysfeedform WHERE (date BETWEEN '" + aMonthAgo + "' AND '" + date + "'), bps.buysnameform WHERE (date BETWEEN '" + aMonthAgo + "' AND '" + date + "'), bps.dailyexpenses WHERE (date BETWEEN '" + aMonthAgo + "' AND '" + date + "')";
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void FillDataGridViewIncome(DataGridView a)
        {
            a.RowHeadersVisible = false;
            string query = "select SUM(total) as 'Income From Daily Sell' from bps.dailysell";
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void FillDataGridViewCashCollection(DataGridView a)
        {
            a.RowHeadersVisible = false;
            string query = "select id,name,amount,collectedby,date from bps.cashcollection;";
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void FillDataGridViewchicks(DataGridView a)
        {
            a.RowHeadersVisible = false;
            string query = "select id,eggproduced,egghatched,name,quantity,rate,discount,payement,collectedby,total,date from bps.chicks;";
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void FillDataGridViewdailyexpenses(DataGridView a)
        {
            a.RowHeadersVisible = false;
            string query = "select id,name,details,amount,date from bps.dailyexpenses;";
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //customer search function
        public static void Search(DataGridView dgv, TextBox tb)
        {
            DataView dv = new DataView(DbDataTable);
            dv.RowFilter = string.Format("name LIKE '%{0}%'", tb.Text);
            dgv.DataSource = dv;
        }

        //method for exporting data from datagridview to EXCEL file

        public static void GenerateExcel(DataGridView dgv, string fn)
        {

            string stOutput = "";
            //Export titles:
            string sHeaders = "";

            for (int j = 0; j < dgv.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dgv.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            //Export data.
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dgv.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(fn, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        //method for exporting data from datagridview to PDF file

        public static void GeneratePdf(DataGridView dgv, SaveFileDialog sfd)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(dgv.Columns.Count);

            //add the headers from the DGV to the table
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgv.Columns[j].HeaderText));

            }

            //flag the first row as header
            table.HeaderRows = 1;

            //add the actual rows from the DGV to the table
            for (int i = 0; i < dgv.Rows.Count; i++)  // <- for loop for adding rows
            {
                for (int k = 0; k < dgv.Columns.Count; k++) // <- for loop for adding columns
                {
                    if (dgv[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgv[k, i].Value.ToString()));
                    }
                }
            }

            //add table to the doc
            doc.Add(table);
            doc.Close();
        }

        public static void EnableNumbersOnly(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
    
        }
        public static void FillDataGridViewRecepit(DataGridView a , string id)
        {
            a.RowHeadersVisible = false;
            var query = "";

            if (string.IsNullOrEmpty(id))
            {
                query = "select id,quantity,payment,species,kilogram,rate,total,name,credit,date from bps.dailysell order by id desc;";
            }
            else
            {
                query = "select id as 'ID',quantity as 'Quantity',payment as 'Payment',species,kilogram,rate,total,name,credit,date from bps.dailysell where id = '" + id + "' order by id desc;";
            }
            
            MySqlCommand cmdDatabase = new MySqlCommand(query, MyCon);

            try
            {
                
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DbDataTable = new DataTable();
                sda.Fill(DbDataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DbDataTable;
                a.DataSource = bindingSource;
                sda.Update(DbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        


           

    }


}
