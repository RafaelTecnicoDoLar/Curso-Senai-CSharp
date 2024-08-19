using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meurpgzao
{
    internal class Batalha : Personagem
    {
        public Batalha()
        {
            int Resposta = 0;

            List<Personagem> personagem;
            Arqueiros arqueiro = new Arqueiros();
            Mago mago = new Mago();
            Guerreiro guerreiro = new Guerreiro();
            Console.Write("Qual personagem você tem preferencia? meu consagrado!: ");
            Resposta = Convert.ToInt32(Console.ReadLine());

            switch (Resposta)
            {
                case 1:
                    Personagem1 = arqueiro.Nome;
                    SortearOponentes(arqueiro);
                    break;
                case 2:
                    Personagem1 = mago.Nome;
                    SortearOponentes(mago);
                    break;
                case 3:
                    Personagem1 = guerreiro.Nome;
                    SortearOponentes(guerreiro);
                    break;
                default:
                    Console.WriteLine("Dados invalidos tente novamente meu consagrado!");
                    return;
            }


            void SortearOponentes(Personagem personagemJogador)
            {
                Random rnd = new Random();
                List<Personagem> oponentes = new List<Personagem>();

                // Adicionando todos os personagens exceto o selecionado pelo jogador
                oponentes.Add(new Arqueiros());
                oponentes.Add(new Mago());
                oponentes.Add(new Guerreiro());

                oponentes.RemoveAll(p => p.Nome == personagemJogador.Nome);

                // Sorteio do oponente
                int indiceOponente = rnd.Next(oponentes.Count);
                Personagem oponente = oponentes[indiceOponente];

                Console.WriteLine($"Oponente: {oponente.Nome}");

                // Iniciar a batalha entre o personagem do jogador e o oponente sorteado
                IniciarBatalha(personagemJogador, oponente);
            }

            void IniciarBatalha(Personagem personagemJogador, Personagem oponente)
            {
                bool batalha = true;
                int contador = 1;

                while (batalha)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Rodada: " + contador + "º");

                    Console.WriteLine("Pontos de Vida do " + personagemJogador.Nome + ": " + personagemJogador.PontosDeVida);
                    Console.WriteLine("Pontos de Vida do " + oponente.Nome + ": " + oponente.PontosDeVida);
                    Console.WriteLine("");

                    // Personagem do jogador ataca o oponente
                    int danoJogador = personagemJogador.Atacar();
                    oponente.PontosDeVida -= danoJogador;
                    Console.WriteLine($"{personagemJogador.Nome} ataca {oponente.Nome} causando {danoJogador} de dano!");

                    // Verifique se o oponente foi derrotado
                    if (oponente.PontosDeVida <= 0)
                    {
                        Console.WriteLine($"{oponente.Nome} foi derrotado! {personagemJogador.Nome} venceu a batalha!");
                        batalha = false;
                        continue;
                    }

                    // Oponente ataca o personagem do jogador
                    int danoOponente = oponente.Atacar();
                    personagemJogador.PontosDeVida -= danoOponente;
                    Console.WriteLine($"{oponente.Nome} ataca {personagemJogador.Nome} causando {danoOponente} de dano!");

                    // Verifique se o personagem do jogador foi derrotado
                    if (personagemJogador.PontosDeVida <= 0)
                    {
                        Console.WriteLine($"{personagemJogador.Nome} foi derrotado! {oponente.Nome} venceu a batalha!");
                        batalha = false;
                        continue;
                    }

                    contador++;
                }
            }
        }
    }
}