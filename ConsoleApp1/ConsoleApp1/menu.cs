using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class menu
    {
        List<string> listaMenu = new List<string>() { };

        produto ExibirLista = new produto();
        espera ExibirEspera = new espera();
        public List<string> Adicionar { get; private set; }
        public List<string> Listar { get; private set; }
        public List<string> ListaEspera { get; private set; }

        public void Menu(List<string> listMenu)
        {
            Console.Clear();
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|         Quitanda do Geraldo        |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| Coloque o código e pressione enter |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| [1] Adicionar produto              |");
            Console.WriteLine("| [2] Aumentar estoque               |");
            Console.WriteLine("| [3] Diminuir produto               |");
            Console.WriteLine("| [4] Vender                         |");
            Console.WriteLine("| [5] Comprar                        |");
            Console.WriteLine("| [6] Listar Produto                 |");
            Console.WriteLine("| [9] Sair do programa               |");
            Console.WriteLine("|------------------------------------|");

            int resposta = Convert.ToInt32(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    //adicionar produto
                    produto ExibirProduto = new produto();
                    ExibirProduto.Adicionar_Produto(Adicionar);
                    Menu(listMenu);
                    break;

                case 2:
                    //aumentar estoque
                    Menu(listMenu);
                    break;

                case 3:
                    //diminuir produto
                    Menu(listMenu);
                    break;

                case 4:
                    //vender
                    Menu(listMenu);
                    break;

                case 5:
                    //comprar
                    Menu(listMenu);
                    break;

                case 6:
                    //listar produto
                    ExibirLista.ListName(Listar);
                    ExibirEspera.Espera(ListaEspera);
                    break;

                case 9:
                    Console.WriteLine("Quitanda do Geraldo agradeçe a sua preferencia!");
                    break;

                default:
                    Console.WriteLine("Dados invalidos! tende novamente!");
                    Menu(listMenu);
                    return;
            }
        }
        internal void Menu(object listMenu)
        {
            throw new NotImplementedException();
        }
    }
}