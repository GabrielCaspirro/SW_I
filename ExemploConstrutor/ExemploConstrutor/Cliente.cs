using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutor
{
    class Cliente
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int Senha { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Senha" + Senha);
        }
    }
}
