using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace BhanjaPoultrySuppliers
{
    public partial class DailySell : Form
    {
        public DailySell()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
            Function.ConnectDB();
            string query = "insert into bps.dailysell(quantity,payment,species,kilogram,total,rate,name,credit,date)values('" + quantity_txtbox.Text + "','" + payments_txtbox.Text + "','" + comboBox1.Text + "','" + kilogram_txtbox.Text + "','" + total_txtbox.Text + "','" + rate_txtbox.Text + "','" + name_txtbox.Text + "', '" + payments_txtbox.Text +"','" + date_lbl.Text + "');";
            MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                name_txtbox.Clear();
                quantity_txtbox.Clear();
                kilogram_txtbox.Clear();
                rate_txtbox.Clear();
                payments_txtbox.Clear();
                credit_lbl.Text = "";
                total_txtbox.Text = "";
                return_amount_lbl.Text = "";
                Function.ConnectDB();
                Function.FillDataGridViewRecepit(dataGridView1, "");
                

                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rate_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double kg = Convert.ToDouble(kilogram_txtbox.Text);
                double rate = Convert.ToDouble(rate_txtbox.Text);

                double total = kg * rate;
                total_txtbox.Text = total.ToString();
            }
            catch (Exception)
            {

            }

            if (sellType_combo.Text == "Feeds")
            {
                calculationForFeed();
            }
        }
        void calculationForFeed() {
            try
            {
                double rate = Convert.ToDouble(rate_txtbox.Text);
                double quantity = Convert.ToDouble(quantity_txtbox.Text);

                double total = rate * quantity;
                total_txtbox.Text = total.ToString();
            }
            catch (Exception)
            {

            }
        
        }
        private void payments_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(total_txtbox.Text);
                double pay = Convert.ToDouble(payments_txtbox.Text);
                double return_amount = pay - total;
                return_amount_lbl.Text = return_amount.ToString();

                var credit = return_amount_lbl.Text;
                credit_lbl.Text = credit.Replace("-", "");
            }
            catch (Exception)
            {

            }
        }

        private void total_btn_Click(object sender, EventArgs e)
        {

        }

        private void quantity_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void payments_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void kilogram_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void rate_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void total_txtbox_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DailySell_Load(object sender, EventArgs e)
        {
            date_lbl.Text = Function.date;
            Function.ConnectDB();
            Function.FillDataGridViewRecepit(dataGridView1, "");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form bill = new Receipt(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bill.Show();
        }


        private void quantity_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (sellType_combo.Text == "Feeds")
            {
                calculationForFeed();
            }
        }

        private void sellType_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sellType_combo.Text == "Feeds" || sellType_combo.Text == "Chicks")
            {

                kilogram_txtbox.Hide();
                kilogram_btn.Hide();
            }
            else
            {
                kilogram_btn.Show();
                kilogram_txtbox.Show();
            }
            if (sellType_combo.Text == "Feeds")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("B0");
                comboBox1.Items.Add("B1");
                comboBox1.Items.Add("B2");
                
            }

            if (sellType_combo.Text == "Chicks")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("layers");
                comboBox1.Items.Add("broilers");
                comboBox1.Items.Add("parents");
                
                
            }
            if (sellType_combo.Text == "Khukhura")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("layers");
                comboBox1.Items.Add("broilers");
                comboBox1.Items.Add("parents");

            }
        }

       

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void srch_textbox_TextChanged(object sender, EventArgs e)
        {
            Function.Search(dataGridView1, srch_textbox);
        }



        void previousCredit()
        {

            try
            {
                Function.ConnectDB();
                string query = "select SUM(credit) as 'credit' from bps.dailysell where name='" +name_txtbox.Text +"'";
                MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var credit = reader.GetInt32("credit");
                    prevcredit_lbl.Text = credit.ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
            }


        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {
            previousCredit();
        }

        private void name_txtbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_txtbox.Text))
            {
                prevcredit_lbl.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

         

       

    }
}
