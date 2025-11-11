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
            attTela();
        }

        private void attTela()
        {
            txtDadoDec.Text = leds.getDados().ToString();
            txtDadoBin.Text = Convert.ToString(leds.getDados(), 2);
            txtDadoHex.Text = Convert.ToString(leds.getDados(), 16).ToUpper();
            btnLed1.Text = (leds.getLeds(1) ? "Desligar" : "Ligar");
            btnLed2.Text = (leds.getLeds(2) ? "Desligar" : "Ligar");
            btnLed3.Text = (leds.getLeds(3) ? "Desligar" : "Ligar");
            btnLed4.Text = (leds.getLeds(4) ? "Desligar" : "Ligar");
            btnLed5.Text = (leds.getLeds(5) ? "Desligar" : "Ligar");
            btnLed6.Text = (leds.getLeds(6) ? "Desligar" : "Ligar");
            btnLed7.Text = (leds.getLeds(7) ? "Desligar" : "Ligar");
            btnLed8.Text = (leds.getLeds(8) ? "Desligar" : "Ligar");
            picLed1.Image = (leds.getLeds(1) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
            picLed2.Image = (leds.getLeds(2) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
            picLed3.Image = (leds.getLeds(3) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
            picLed4.Image = (leds.getLeds(4) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
            picLed5.Image = (leds.getLeds(5) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
            picLed6.Image = (leds.getLeds(6) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
            picLed7.Image = (leds.getLeds(7) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
            picLed8.Image = (leds.getLeds(8) ? Properties.Resources.lamp_acesa : Properties.Resources.lamp_apagada);
        }
        private void btnLed1_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(1))
            {
                leds.desligar(1);
            }
            else
            {
                leds.ligar(1);
            }
            attTela();
        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(2))
            {
                leds.desligar(2);
            }
            else
            {
                leds.ligar(2);
            }
            attTela();
        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(3))
            {
                leds.desligar(3);
            }
            else
            {
                leds.ligar(3);
            }
            attTela();
        }

        private void btnLed4_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(4))
            {
                leds.desligar(4);
            }
            else
            {
                leds.ligar(4);
            }
            attTela();
        }

        private void btnLed5_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(5))
            {
                leds.desligar(5);
            }
            else
            {
                leds.ligar(5);
            }
            attTela();
        }

        private void btnLed6_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(6))
            {
                leds.desligar(6);
            }
            else
            {
                leds.ligar(6);
            }
            attTela();
        }

        private void btnLed7_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(7))
            {
                leds.desligar(7);
            }
            else
            {
                leds.ligar(7);
            }
            attTela();
        }

        private void btnLed8_Click(object sender, EventArgs e)
        {
            if (leds.getLeds(8))
            {
                leds.desligar(8);
            }
            else
            {
                leds.ligar(8);
            }
            attTela();
        }

    }
}
