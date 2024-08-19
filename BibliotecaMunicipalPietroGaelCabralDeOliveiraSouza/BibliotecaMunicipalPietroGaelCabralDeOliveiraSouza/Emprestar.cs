using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMunicipalPietroGaelCabralDeOliveiraSouza
{
    internal class Emprestar
    {
        public Emprestar(List<Livro> Livro) 
        {
            Console.Clear();
            foreach (Livro item in Livro)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
