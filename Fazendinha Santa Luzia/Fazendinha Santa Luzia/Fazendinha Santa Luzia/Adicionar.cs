using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha_Santa_Luzia
{
    internal class Adicionar : Gerenciar
    {
        public Adicionar(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals) 
        {
            Ave ave = new Ave();
            Bovino bovino = new Bovino();

            Console.Clear();
            Console.WriteLine("Fazendinha Santa Luzia");
            Console.WriteLine("[1] Animal");
            Console.WriteLine("[2] Planta");
            Console.WriteLine("[9] Voltar");

            int Resposta = Convert.ToInt32(Console.ReadLine());

            switch (Resposta)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Fazendinha Santa Luzia");
                    Console.WriteLine("[1] Ave");
                    Console.WriteLine("[2] Bovino");
                    Console.WriteLine("[9] Voltar");
                    Console.WriteLine("Você quer adicionar uma ave ou um Bovino?");
                    int Resoposta1 =  Convert.ToInt32(Console.ReadLine());
                    
                    if (Resoposta1 == 1)
                    {
                        ave.AdicionarAve(aves, bovinos, frutas, vegetals);
                    } else if (Resoposta1 == 2)
                    {
                        bovino.AdicionarBovino(aves, bovinos, frutas, vegetals);
                    }
                    else
                    {
                        Console.WriteLine("Dados invalidos, tente novamente");
                        Adicionar adicionar = new Adicionar(aves, bovinos, frutas, vegetals);
                    }

                    break;

                case 2:
                    

                    break;

                case 9:
                    Console.Clear();
                    Menu menu = new Menu(aves, bovinos, frutas, vegetals);

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Dados invalidos!, precione enter tente novamente!");
                    Console.ReadLine();
                    Adicionar adicionar1 = new Adicionar(aves, bovinos, frutas, vegetals);
                    return;
            }
        }
    }  
}