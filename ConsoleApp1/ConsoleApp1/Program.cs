using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static List<string> listMenu;
        static void Main()
        {
            menu Exibirmenu = new menu();
            Exibirmenu.Menu(listMenu);
        }
    }
}