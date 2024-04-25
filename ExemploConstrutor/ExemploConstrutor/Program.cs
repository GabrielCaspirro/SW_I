namespace ExemploConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo Construtor");
            Cliente cliente = new Cliente("Gabriel");
            cliente.Email = "GAB@gmail.com";
            cliente.Senha = 2122344;
            cliente.MostraDados();
        }
    }
}