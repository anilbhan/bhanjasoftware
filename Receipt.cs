using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;


namespace BhanjaPoultrySuppliers
{
    public partial class Receipt : Form
    {
        public Receipt(string id)
        {
            
            InitializeComponent();
            label1.Text = id;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            date_lbl.Text = Function.date;
            Function.ConnectDB();


            try
            {
                string query = "select * from bps.dailysell";
                MySqlCommand cmd = new MySqlCommand(query, Function.MyCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var quantity = reader.GetInt32("quantity");
                    var payment = reader.GetInt32("payment");
                    var species = reader.GetString("species");
                    var kilogram = reader.GetInt32("kilogram");
                    var rate = reader.GetInt64("rate");
                    var total = reader.GetInt64("total");
                    var name = reader.GetString("name");
                    var credit = reader.GetInt32("credit");

                    name_lbl.Text = name.ToString();
                    items_lbl.Text = species.ToString();
                    quantity_lbl.Text = quantity.ToString();
                    payment_lbl.Text = payment.ToString();
                    kg_lbl.Text = kilogram.ToString();
                    total_lbl.Text = total.ToString();
                    credit_lbl.Text = credit.ToString();
                    rate_lbl.Text = rate.ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

            this.Close();

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
            Point p = new Point(0, 0);
            e.Graphics.DrawImage(img, p);
        }

        private void credit_lbl_Click(object sender, EventArgs e)
        {

        }

       
    }
}
