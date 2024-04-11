using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public float Altura { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data de Nascimento: " + DataNascimento);
            Console.WriteLine("Altura: " + Altura);
        }


        public int CalcularIdade()
        {
            return DateTime.Today.Year - DataNascimento.Year;
        }
    }
}
