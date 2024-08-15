using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_sistemamao_pourr
{
    internal class Ler
    {
        public Ler()
        {
            Console.Clear();
            Console.WriteLine("Voce chegou em ler!");
            Console.WriteLine("Precione enter para continuar");
            Console.ReadLine();
            Menu menu = new Menu();
        }
    }
}
