using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public float Resultado { get; set; }

        public void Calcular()
        {
            Console.WriteLine("Digite o valor da base da figura: ");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da base da figura: ");
            Altura = float.Parse(Console.ReadLine());

            Resultado = Base * Altura;

            if(Base != Altura)
            {
                Console.WriteLine($"A área é de {Resultado} e a figura é um retângulo.");
            }
            else
            {
                Console.WriteLine($"A área é de {Resultado} e a figura é um quadrado.");
            }
        }

        public string Dados()
        {
            return $"Base: {Base} \nAltura: {Altura}";
        }
    }
}
