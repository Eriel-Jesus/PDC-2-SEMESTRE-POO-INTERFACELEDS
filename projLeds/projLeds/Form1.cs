using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {
        private Leds leds;
        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            txtDadoDec.Text = leds.getDado().ToString();
            txtDadoBin.Text = Convert.ToString(leds.getDado(), 2);
            txtDadoHex.Text = Convert.ToString(leds.getDado(), 16).ToUpper();
            btnLed1.Text = (leds.getLed(1) ? "Off" : "On");
            btnLed2.Text = (leds.getLed(2) ? "Off" : "On");
            btnLed3.Text = (leds.getLed(3) ? "Off" : "On");
        }

        private void btnLed1_Click(object sender, EventArgs e)
        {
            if (leds.getLed(1))
            {
                leds.apagar(1);
            }
            else
            {
                leds.acender(1);
            }
            atualizaInterface();
        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (leds.getLed(2))
            {
                leds.apagar(2);
            }
            else
            {
                leds.acender(2);
            }
            atualizaInterface();
        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            if (leds.getLed(3))
            {
                leds.apagar(3);
            }
            else
            {
                leds.acender(3);
            }
            atualizaInterface();
        }

    }
}
