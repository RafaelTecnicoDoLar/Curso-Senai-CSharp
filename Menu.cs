using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDoTiao
{
    internal class Menu
    {
        public Menu()
            {
                Console.Clear();
                Console.WriteLine("Oficina Do Tião");
                Console.WriteLine("[1] Adicionar");
                Console.WriteLine("[2] Ler");
                Console.WriteLine("[3] Atualizar");
                Console.WriteLine("[4] Deletar");
                Console.WriteLine("[9] Sair");

                int Resposta = Convert.ToInt32(Console.ReadLine());

                switch (Resposta)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 9:
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Dados inválidos, precione enter e tente novamente!");
                        Menu menu = new Menu();
                        break;
                }
         }
     }   
}