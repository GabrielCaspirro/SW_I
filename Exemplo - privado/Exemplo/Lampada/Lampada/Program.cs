namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objeto
            Lampada lampada = new Lampada();

            //Método
            lampada.Ligar();
            lampada.LampColor("Verde");
            lampada.LampPower(140);
            Console.WriteLine($"Tá ligada?: {lampada.EstaLigada()}\n Potência: {lampada.LampP()}\n Cor:{lampada.LampC()}");
        }
    }
}
