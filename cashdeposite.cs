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
    public partial class cashdeposite : Form
    {
        public cashdeposite()
        {
            InitializeComponent();
        }

        private void cashsave_textbox_Click(object sender, EventArgs e)
        {
            string MyConnection = "datasource=localhost;port=3306;username=root;password=";
            string query = "insert into bps.cashdeposite(companyname,amount,purpose,depositedby,date)values('" + cashcompanyname_textbox.Text + "','" + amount_textbox.Text + "','" + purpose_textbox.Text + "','" + deposite_textbox.Text + "','"+date_lbl.Text+"');";
            MySqlConnection myconn = new MySqlConnection(MyConnection);
            MySqlCommand cmd = new MySqlCommand(query, myconn);
            MySqlDataReader reader;
            try
            {
                myconn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                cashcompanyname_textbox.Clear();
                deposite_textbox.Clear();
                purpose_textbox.Clear();
                amount_textbox.Clear();
                

                

                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cashdeposite_Load(object sender, EventArgs e)
        {
            date_lbl.Text = Function.date;
        }
    }
}
