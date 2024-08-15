using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha_Santa_Luzia
{
    internal class Program
    {
        static void Main(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
        {
            Menu menu = new Menu(aves, bovinos, frutas, vegetals);
        }
    }
}
