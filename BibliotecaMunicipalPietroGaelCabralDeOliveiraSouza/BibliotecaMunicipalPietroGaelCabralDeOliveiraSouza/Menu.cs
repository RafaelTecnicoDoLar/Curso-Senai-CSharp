using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMunicipalPietroGaelCabralDeOliveiraSouza
{
    internal class Menu
    {
        List <Livro> livro;
        Livro livros;
        public Menu (List<Membro> lista_membros, List <Livro> Livro) 
        {
            Menu menu;
            Console.Clear();
            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("| Biblioteca Municipal Pietro Gael Cabral de Oliveira Souza |");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("| [1] Livros                                                |");
            Console.WriteLine("| [2] Membro                                                |");
            Console.WriteLine("| [3] Biblioteca                                            |");
            Console.WriteLine("| [9] Sair                                                  |");
            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("Coloque o código e precione enter");

            int resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Livros paginalivro = new Livros (livro);
                    break;

                case 2:
                    Membro paginamembro = new Membro(livro);
                    break;

                case 3:
                    Biblioteca paginabiblioteca = new Biblioteca(livro);
                    break;
                case 9:
                    Console.WriteLine("Fechando o programa");
                    break;
                 
                    default: 
                    Console.WriteLine("Código inválido! Precione enter!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
