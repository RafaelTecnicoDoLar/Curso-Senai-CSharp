using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMunicipalPietroGaelCabralDeOliveiraSouza
{
    internal class AdicionarLivro
    {
        public List<Membro> Lista_membros;
        public List<Livro> Lista_livro;

        public AdicionarLivro(List<Membro> lista_membros, List<Livro> lista_livro)
        {
            Lista_membros = lista_membros;
            Lista_livro = lista_livro;

            Livro livro = new Livro();

            Console.WriteLine("Por favor insira o título do livro");
            livro.Titulo = Console.ReadLine();

            List<Livro> livros = adicionarLivro(livro);

            Menu menu = new Menu(lista_membros, lista_livro);
        }

        public List<Livro> adicionarLivro(Livro livro)
        {
            Lista_livro.Add(livro);

            return Lista_livro;
        }
    }
}
