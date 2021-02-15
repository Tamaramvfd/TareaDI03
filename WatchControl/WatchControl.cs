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
        private Boolean _format = true;
        private DateTime _alarm;
       
        public Boolean Format
        {
            get { return _format; }
            set { _format = value; }
        }
        public DateTime Alarm
        {
            get { return _alarm; }
            set { _alarm = value; }
        }
        public WatchControl()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            
        }
        private void WatchControl_Load(object sender, EventArgs e)
        {
            //lbDate.Text = DateTime.Now.ToString("ddd, dd/MM/yy");
            //lbHourMin.Text = DateTime.Now.ToString("HH:mm");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbSecond.Text = DateTime.Now.ToString("ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (radioButton_CheckedChanged())
            {
                lbHourMin.Text = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                lbHourMin.Text = DateTime.Now.ToString("hh:mm tt");
            }
        }

        public Boolean radioButton_CheckedChanged()
        {
            if(radioButton12.Checked)
            {
                return _format = false;
            }
            else
            {
                return _format = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("ddd, dd/MM/yy");
        }

        private void btAlarm_Click(object sender, EventArgs e)
        {
            Dashboard ad = new Dashboard(_format);
            ad.Show();
        }
    }
}

