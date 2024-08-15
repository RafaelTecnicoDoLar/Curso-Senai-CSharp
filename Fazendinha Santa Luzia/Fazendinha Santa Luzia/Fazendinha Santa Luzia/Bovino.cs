using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha_Santa_Luzia
{
    internal class Bovino : Animal
    {
        public string ProduzLeite;

        public void AdicionarBovino(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
        {
            Console.WriteLine("Você chegou na classe bovino");
            Console.ReadLine();
            Adicionar adicionar = new Adicionar(aves, bovinos, frutas, vegetals);
        }
        public void Ordenhar()
        {

        }
    }
}
