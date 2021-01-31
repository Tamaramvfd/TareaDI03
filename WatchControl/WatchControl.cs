using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchControl
{
    public partial class WatchControl : UserControl
    {
       
        public WatchControl()
        {
            InitializeComponent();
            cbFormat.Text = "24";
            cbFormat.Items.Add("12");
            cbFormat.Items.Add("24");
        }
        private void WatchControl_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("ddd, dd/MM/yy");
            //lbHourMin.Text = DateTime.Now.ToString("HH:mm");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbFormat.Text == "12")
            {
                lbHourMin.Text = DateTime.Now.ToString("hh:mm tt");
            }
            else if (cbFormat.Text == "24")
            {
                lbHourMin.Text = DateTime.Now.ToString("HH:mm");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbSecond.Text = DateTime.Now.ToString("ss");
        }

    }
}

