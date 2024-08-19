using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace meurpgzao
{
    internal class Personagem
    {
        public string Personagem1;
        public string Personagem2;
        public string Nome;
        public string Especialidade;
        public int    Nivel;
        public double PontosDeVida;
        public double PontosDeStamina;
        public double PontosDeMana;
        public double PontosVida;
        public double PontosStamina;
        public double PontosMana;
        public double ConsumoDeStamina;
        public double ConsumoDeMana;
        public double Defesa;
        public double HitBasico;
        public double Forca;
        public double Agilidade;
        public double Vitalidade;
        public double Energia;
        public string Oponente;
        public double Dano;
        public double DanoSkill1;
        public double DanoSkill2;
        public double DanoUltimate;
        public double Ataque;
        public void CalcularVida()
        {
            PontosDeVida    = PontosVida + (PontosVida * (Vitalidade / 100));
            PontosDeMana    = PontosMana + (PontosMana * (Energia / 100));
            PontosDeStamina = PontosStamina + (PontosStamina * (Energia / 100));
        }
        public void CalcularDano()
        {
            Dano = Forca + ((Forca + Agilidade) * (Forca /100));
        }
        public void CalcularDefesa()
        {
            Defesa = (Nivel+(PontosDeVida*(Nivel/100))/100);
            Dano = Dano - (Dano * Defesa);
        }
        public void Informacoes()
        {
            Console.WriteLine("Nome:               " + Nome);
            Console.WriteLine("Especialidade:      " + Especialidade);
            Console.WriteLine("Força:              " + Forca);
            Console.WriteLine("Agilidade:          " + Agilidade);
            Console.WriteLine("Vitalidade:         " + Vitalidade);
            Console.WriteLine("Energia:            " + Energia);
            Console.WriteLine("Pontos de Vida:     " + PontosDeVida);
            Console.WriteLine("Pontos de Stamina:  " + PontosDeStamina);
            Console.WriteLine("Pontos de Mana:     " + PontosDeMana);
            Console.WriteLine("Dano Físico:        " + Dano);
            Console.WriteLine("skill 1:            " + DanoSkill1);
            Console.WriteLine("Skill 2:            " + DanoSkill2);
            Console.WriteLine("Ultimate:           " + DanoUltimate);
            Console.WriteLine("Consumo de Stamina: " + ConsumoDeStamina);
            Console.WriteLine("");
        }
        public virtual int Atacar()
        {
            // Implementar a lógica do ataque aqui (retorna o dano causado)
            return (int)Dano; // Exemplo de dano fixo
        }
    }
}