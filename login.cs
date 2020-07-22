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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand selectCommand = new MySqlCommand("select * from bps.login where username='" + user_txt.Text + "' and password='" + Function.Md5HashGenerator(password_txt) + "';", myConn);
                myConn.Open();
                MySqlDataReader myReader = selectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    this.Hide();
                    index f2 = new index();
                    f2.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password....Access Denied!!!");
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!! Try Again");
                    myConn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}