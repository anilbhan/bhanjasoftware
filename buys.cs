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
    public partial class buys : Form
    {
        public buys()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameform_savebtn_Click(object sender, EventArgs e)
        {
            string query = "insert into bps.buysnameform(companyname,quantity,rate,kilogram,types,total,date)values('" + companyname_btn.Text + "','" + quantity_btn.Text + "','" + rate_btn.Text + "','" + kilogram_btn.Text + "','" + nameformtype_combobox.Text + "','" + total_lbl.Text + "','" + date_lbl.Text + "');";
            Function.ConnectDB();
            MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                reader.Close();
                companyname_btn.Clear();
                quantity_btn.Clear();
                rate_btn.Clear();
                kilogram_btn.Clear();
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kilogram_btn_TextChanged(object sender, EventArgs e)
        {
            nameFormTotal();
        }
        void nameFormTotal() {

            try
            {

                double rate = Convert.ToDouble(rate_btn.Text);
                double kg = Convert.ToDouble(kilogram_btn.Text);
                double total = rate * kg;
                total_lbl.Text = total.ToString();


            }
            catch (Exception)
            {

            }
        }

        private void chicks_savebtn_Click(object sender, EventArgs e)
        {
            string query = "insert into bps.buyschicksform(companyname,quantity,rate,discount,total,date)values('" + chickscompanyname_btn.Text + "','" + chicksquantity_btn.Text + "','" + chicksrate_btn.Text + "', '" + chicks_discount.Text + "','" + chicksbuys_lbl.Text + "','" + date_lbl.Text + "');";
            Function.ConnectDB();
            MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                reader.Close();
                chickscompanyname_btn.Clear();
                chicksrate_btn.Clear();
                chicksquantity_btn.Clear();
                chicks_discount.Clear();
                chicksbuys_lbl.Text = "";       

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void chicks_discount_TextChanged(object sender, EventArgs e)
        {
            chicksTotal();
        }

        void chicksTotal()
        {
            try
            {

                double quantity = Convert.ToDouble(chicksquantity_btn.Text);
                double rate = Convert.ToDouble(chicksrate_btn.Text);
                double discount_num = Convert.ToDouble(chicks_discount.Text);

                double quantity_after_discount = quantity - discount_num;

                double total = quantity_after_discount * rate;
                chicksbuys_lbl.Text = total.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void feeds_savebtn_Click(object sender, EventArgs e)
        {
            

            string query = "insert into bps.buysfeedform(companyname,quantity,rate,date,type,total)values('" + feedscompany_btn.Text + "','" + feedsquantity_btn.Text + "','" + feedsrate_btn.Text + "','" + date_lbl.Text + "', '" + feeds_combobox.Text + "','" + Feeds_lbl.Text + "');";
            Function.ConnectDB();
            MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                reader.Close();
                feedscompany_btn.Clear();
                feedsquantity_btn.Clear();
                feedsrate_btn.Clear();
                feeds_combobox.Text = "";
                Feeds_lbl.Text = "";







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            

        private void buys_Load(object sender, EventArgs e)
        {
            date_lbl.Text = Function.date;
        }

        private void chicksrate_btn_TextChanged(object sender, EventArgs e)
        {
            chicksTotal();
        }

        private void chicksquantity_btn_TextChanged(object sender, EventArgs e)
        {
            chicksTotal();
        }

        private void rate_btn_TextChanged(object sender, EventArgs e)
        {
            nameFormTotal();
        }

        private void feedsrate_btn_TextChanged(object sender, EventArgs e)
        {
            feedsTotal();
        }
        void feedsTotal() {

            try
            {

                double quantity = Convert.ToDouble(feedsquantity_btn.Text);
                double rate = Convert.ToDouble(feedsrate_btn.Text);
                double total = quantity * rate;
                Feeds_lbl.Text = total.ToString();
            }
            catch (Exception)
            {

            }
        
        
        }

        private void feedsquantity_btn_TextChanged(object sender, EventArgs e)
        {
            feedsTotal();
        }

       
        
           

  
    }
}
