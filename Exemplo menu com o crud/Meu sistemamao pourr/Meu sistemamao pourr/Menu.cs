using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_sistemamao_pourr
{
    internal class Menu
    {
        public Menu()
        {
            Console.Clear();
            Console.WriteLine("Meu sistemao porra!");
            Console.WriteLine("[1] Adicionar");
            Console.WriteLine("[2] Ler");
            Console.WriteLine("[3] Atualizar");
            Console.WriteLine("[4] Deletar");
            Console.WriteLine("[9] Sair");

            int Resposta = Convert.ToInt32(Console.ReadLine());

            switch (Resposta)
            {
                case 1: 
                    Adicionar adicionar = new Adicionar();
                    break;

                case 2:
                    Ler ler = new Ler();    
                    break;

                case 3:
                    Atualizar atualizar = new Atualizar();
                    break;

                case 4:
                    Deletar deletar = new Deletar();
                    break;

                case 9:

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Dados invalidos!, precione enter tente novamente!");
                    Console.ReadLine();
                    Menu menu = new Menu();
                    return;
            }
        }
        
    }
}
