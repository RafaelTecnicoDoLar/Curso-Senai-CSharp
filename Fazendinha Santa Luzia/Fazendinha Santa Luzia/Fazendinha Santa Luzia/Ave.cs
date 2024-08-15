using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha_Santa_Luzia
{
    internal class Ave : Animal
    {
        public string PoeOvos;
            public void AdicionarAve(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
            {
                bool Resposta = true;
                while (Resposta == true)
                {
                    Console.Clear();
                    Console.WriteLine("Fazendinha Santa Luzia");
                    Console.WriteLine("Qual ave você quer adicionar?");
                    //aves.Add(Console.ReadLine());

                    Console.WriteLine("Você quer adicionar outro? 1/0");
                    int Resposta1 = Convert.ToInt32(Console.ReadLine());

                    if (Resposta1 == 0)
                    {
                        Resposta = false;
                    }
                }
                Adicionar adicionar = new Adicionar(aves, bovinos, frutas, vegetals);
            }
            public void LerAves(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
            {

            }
            public void AtualizarAves(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
            {

            }
            public void Deletar(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
            {
                Console.WriteLine("Qual ave você quer remover da lista?");
            }
            public void ColetarOvos(List<Ave> aves, List<Bovino> bovinos, List<Fruta> frutas, List<Vegetal> vegetals)
            {
                Console.WriteLine("Coletando os ovos!");
            }
    }
}