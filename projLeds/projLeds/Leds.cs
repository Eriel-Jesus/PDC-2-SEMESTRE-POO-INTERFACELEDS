using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLeds
{
    internal class Leds
    {
        private byte dado;
        public Leds()
        {
            this.dado = 0;
        }

        public Leds(byte dado) 
        { 
            this.dado = dado;
        }

        public byte getDados()
        {
            return this.dado;
        }
        public void ligar(int led)
        {
            int ou = (int)(Math.Pow(2, led - 1));
            this.dado = (byte)((int)(this.dado) | ou);
        }

        public void desligar(int led)
        {
            int e = (int)(255 - Math.Pow(2, led - 1));
            this.dado = (byte)((int)(this.dado) & e);
        }

        public bool getLeds(int led)
        {
            byte checar;
            int e = (int)(Math.Pow(2, led - 1));
            checar = (byte)((int)(this.dado) & e);
            return (checar > 0);
        }


    }
}
