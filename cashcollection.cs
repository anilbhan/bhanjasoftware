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
    public partial class cashcollection : Form
    {
        public cashcollection()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cashcollection_Load(object sender, EventArgs e)
        {
            Function.ConnectDB();
            Function.FillDataGridViewCashCollection(dataGridView1);
            label1.Text = Function.date;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string MyConnection = "datasource=localhost;port=3306;username=root;password=;Convert Zero DateTime= true";
            string query = "insert into bps.cashcollection(name,amount,collectedby,date)values('" + name_btnbox.Text + "','" + amount_txtbox.Text + "','" + collectedby_txtbox.Text + "','" + label1.Text + "');";
            MySqlConnection myconn = new MySqlConnection(MyConnection);
            MySqlCommand cmd = new MySqlCommand(query, myconn);
            MySqlDataReader reader;
            try
            {
                myconn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");

                Function.FillDataGridViewCashCollection(dataGridView1);

                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Function.Search(dataGridView1, textBox1);
        }

        private void amount_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }


        void EnableRegisterButton1()
        {
            if (string.IsNullOrEmpty(name_btnbox.Text) ||
                string.IsNullOrEmpty(amount_txtbox.Text) ||
                string.IsNullOrEmpty(collectedby_txtbox.Text))
                
            {
                save_btn.Enabled = false;
            }
            else
            {
                save_btn.Enabled = true;
            }
        }



        }
   }
