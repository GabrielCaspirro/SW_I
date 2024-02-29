using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; }
        private int Potencia { get; set; }
        private string? Cor { get; set; }

        public void Ligar()
        {
            Ligada = true;
        }
        public void Desligar()
        {
            Ligada = false;
        }
        public bool EstaLIgada()
        {
            return Ligada;
        }

        public void LampColor(string color)
        {
            Cor = color;
        }

        public string LampC()
        {
            return Cor;
        }

        public int LampP()
        {
            return Potencia;
        }

        public void LampPower(int power)
        {
            Potencia = power;
        }
    }
}
