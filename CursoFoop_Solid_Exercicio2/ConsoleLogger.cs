using System;

namespace Solid_Exercise2
{
    class ConsoleLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
