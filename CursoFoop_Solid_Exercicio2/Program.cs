using System;

namespace Solid_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger myLogFile = new FileLogger();
            ILogger myLogConsole = new ConsoleLogger();

            //choose between myLogFile or myLogConsole
            Pedido pedido = new Pedido(myLogFile);
            pedido.AdicionarPedido();

            Console.ReadLine();
        }
    }
}
