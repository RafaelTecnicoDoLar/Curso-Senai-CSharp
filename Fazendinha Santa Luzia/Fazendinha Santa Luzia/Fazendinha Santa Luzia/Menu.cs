using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Fazendinha_Santa_Luzia
{
    internal class Menu
    {
        public Menu(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
        {
            Console.Clear();
            Console.WriteLine("Fazendinha Santa Luzia");
            Console.WriteLine("[1] Adicionar");
            Console.WriteLine("[2] Ler");
            Console.WriteLine("[3] Atualizar");
            Console.WriteLine("[4] Deletar");
            Console.WriteLine("[9] Sair");

            int Resposta = Convert.ToInt32(Console.ReadLine());

            switch (Resposta)
            {
                case 1:
                    Adicionar adicionar = new Adicionar(aves, bovinos, frutas, vegetals);

                    break;

                case 2:
                    Ler ler = new Ler(aves, bovinos, frutas, vegetals);

                    break;

                case 3:
                    Atualizar atualizar = new Atualizar(aves, bovinos, frutas, vegetals);

                    break;

                case 4:
                    Deletar deletar = new Deletar(aves, bovinos, frutas, vegetals);

                    break;

                case 9:
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Dados invalidos!, precione enter tente novamente!");
                    Console.ReadLine();
                    Menu menu = new Menu(aves, bovinos, frutas, vegetals);
                    return;
            }
        }

    }
}
