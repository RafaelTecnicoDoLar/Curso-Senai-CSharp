using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Santo_Andre
{
    internal class Program : Correntista
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<Conta> contas = new List<Conta>();
            PaginaInicial paginaInicial = new PaginaInicial(contas);
            
        }
    }
}