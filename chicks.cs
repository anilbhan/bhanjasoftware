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
    public partial class chicks : Form
    {
        public chicks()
        {
            InitializeComponent();
        }

        private void chicks_Load(object sender, EventArgs e)
        {
            date_lbl.Text = Function.date;
            Function.ConnectDB();
            Function.FillDataGridViewchicks(chicksdatagridview1);
        }

       
        private void save_btn_Click(object sender, EventArgs e)
        {
            string MyConnection = "datasource=localhost;port=3306;username=root;password=";
            string query = "insert into bps.chicks(eggproduced,egghatched,name,quantity,rate,discount,payement,collectedby,total,date)values('" + eggproduced_textbox.Text + "','" + egghatched_textbox.Text + "','" + eggsellto_textbox.Text + "','" + quantity_textbox.Text + "','" + rate_textbox.Text + "','" + discount_textbox.Text + "','" + payement_textbox.Text + "','" + collectedby_textbox.Text + "','" + label1.Text + "','" + date_lbl.Text + "');";
            MySqlConnection myconn = new MySqlConnection(MyConnection);
            MySqlCommand cmd = new MySqlCommand(query, myconn);
            MySqlDataReader reader;
            try
            {
                myconn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show(" Your Data has been saved sucessfully");
                eggproduced_textbox.Clear();
                egghatched_textbox.Clear();
                eggsellto_textbox.Clear();
                quantity_textbox.Clear();
                rate_textbox.Clear();
                discount_textbox.Clear();
                label1.Text = "";
                payement_textbox.Clear();

               

                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eggproduced_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void egghatched_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void quantity_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void rate_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        private void payement_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function.EnableNumbersOnly(e);
        }

        void EnableRegisterButton1()
        {
            if (string.IsNullOrEmpty(quantity_textbox.Text) ||
                string.IsNullOrEmpty(rate_textbox.Text) ||             
                string.IsNullOrEmpty(collectedby_textbox.Text)|| 
                string.IsNullOrEmpty(eggproduced_textbox.Text)|| 
                string.IsNullOrEmpty(eggsellto_textbox.Text)|| 
                string.IsNullOrEmpty(egghatched_textbox.Text)|| 
                string.IsNullOrEmpty(discount_textbox.Text)|| 
                string.IsNullOrEmpty(payement_textbox.Text)) 
                
            {
                save_btn.Enabled = false;
            }
            else
            {
                save_btn.Enabled = true;
            }
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF Documents (*.pdf)|*.pdf";
                sfd.FileName = "Export_Data.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Function.GeneratePdf(chicksdatagridview1, sfd);
                 MessageBox.Show("Data Successfully Exported as PDF File", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Function.Search(chicksdatagridview1, chickssearch);
        }

        private void payement_textbox_TextChanged(object sender, EventArgs e)
        {
            calculationForChicks();
        }   

        

        private void discount_textbox_TextChanged(object sender, EventArgs e)
        {
            calculationForChicks();
        }
        void calculationForChicks() 
        
        {
            try
            {
                double rate = Convert.ToDouble(rate_textbox.Text);
                double quan = Convert.ToDouble(quantity_textbox.Text);
                double dis = Convert.ToDouble(discount_textbox.Text);
                double payment = Convert.ToDouble(payement_textbox.Text);
                double total = (quan - dis) * rate - payment;
                label1.Text = total.ToString();
                
                
            }
            catch(Exception) 
            { 
            
            
            
            }
        }

        private void quantity_textbox_TextChanged(object sender, EventArgs e)
        {
            calculationForChicks();
        }

        private void rate_textbox_TextChanged(object sender, EventArgs e)
        {
            calculationForChicks();
        }


       

       
       
    
    
    }
}

