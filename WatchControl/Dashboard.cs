using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchControl
{
    public partial class Dashboard : Form
    {
        public Dashboard(Boolean formato)
        {
            InitializeComponent();

            if (!formato)
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (i < 10)
                    {
                        cbhour.Items.Add("0" + i);
                    }
                    else
                    {
                        cbhour.Items.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 23; i++)
                {
                    if (i < 10)
                    {
                        cbhour.Items.Add("0" + i);
                    }
                    else
                    {
                        cbhour.Items.Add(i);
                    }
                    
                }
            }

            for (int i = 0; i <= 59; i++)
            {
                if (i < 10)
                {
                    cbMin.Items.Add("0"+i);
                }
                else
                {
                    cbMin.Items.Add(i);
                }
                
            }

        }

    }
}
