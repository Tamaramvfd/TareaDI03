using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDI03Componente
{
    
    public partial class WatchComponent : UserControl
    {
        public WatchComponent()
        {
            //Reloj reloj = new Reloj(false);
            InitializeComponent();
            cbFormat.Text = "24";
            cbFormat.Items.Add("12");
            cbFormat.Items.Add("24");

        }

        private void WatchComponent_Load(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString("ddd, dd/MM/yy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //horaMinut.Text = DateTime.Now.ToString("HH:mm");
            if (cbFormat.Text == "12")
            {
                horaMinut.Text = DateTime.Now.ToString("hh:mm tt");
            }
            else if (cbFormat.Text == "24")
            {
                horaMinut.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            second.Text = DateTime.Now.ToString("ss");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
