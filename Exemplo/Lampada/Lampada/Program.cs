namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objeto
            Lampada lampada = new Lampada();
            Lampada lampada2 = new Lampada();

            //Atributos
            lampada.cor = "branca";
            lampada.potencia = 150;
            lampada.ligada = false;

            lampada2.cor = "verde";
            lampada2.potencia = 120;
            lampada2.ligada = true;
             
            Console.WriteLine("Essa é a lampada 1!!");
            Console.WriteLine($"A Lampada é {lampada.cor}, tem a potencia de {lampada.potencia}w. Ela está ligada? R: {lampada.ligada}");
            Console.WriteLine("Essa é a lampada 2!!");
            Console.WriteLine($"A Lampada é {lampada2.cor}, tem a potencia de {lampada2.potencia}w. Ela está ligada? R: {lampada2.ligada}");
        }
    }
}