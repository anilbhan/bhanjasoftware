using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BhanjaPoultrySuppliers
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Timer clock = new Timer { Interval = 3000 };

            clock.Tick += new EventHandler(timer_tick);
            clock.Start();
        }

        private void timer_tick(object sender, EventArgs eArgs)
        {

            Close();


        }
    }
}
