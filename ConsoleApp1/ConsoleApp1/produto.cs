using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class produto
    {
        List<string> Nome = new List<string>() {"JBL Bombox 3"};
        List<string> Descricao = new List<string>() {"JBL Bombox 3, Super caixa de som aprova d´agua, com 24h de bateria para dar um up na sua festa"};
        List<double> Valor_Unitario = new List<double>() {2600.00};
        List<double> Peso = new List<double>() {4};
        List<double> Altura = new List<double>() {30};
        List<double> Largura = new List<double>() {50};
        List<double> Comprimento = new List<double>() {20};
        List<string> Unidade_de_Medida = new List<string>() {"RMS"};
        List<double> Porcentagem_de_Impostos = new List<double>() {25};
        List<int> Quantidade_Estoque = new List<int>() {6};
        public void Adicionar_Produto(List<string> Adicionar)
        {
            Console.WriteLine("Qual o Nome do produto, meu consagrado!");
            Nome.Add(Console.ReadLine());

            Console.WriteLine("Qual a descrição do produto, meu consagrado!");
            Descricao.Add(Console.ReadLine());

            Console.WriteLine("Qual o Valor Unitario do produto, meu consagrado!");
            Valor_Unitario.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Qual o Peso do produto, meu consagrado!");
            Peso.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Qual a Altura do produto, meu consagrado!");
            Altura.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Qual a Largura do produto, meu consagrado!");
            Largura.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Qual o Comprimento do produto, meu consagrado!");
            Comprimento.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Qual a Unidade de Medida do produto, meu consagrado!");
            Unidade_de_Medida.Add(Console.ReadLine());

            Console.WriteLine("Qual a Porcentagem de Impostos do produto, meu consagrado!");
            Porcentagem_de_Impostos.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Qual a Quantidade Estoque do produto, meu consagrado!");
            Quantidade_Estoque.Add(Convert.ToInt32(Console.ReadLine()));


        }
        public void ListName(List<string> Listar)
        {
            foreach (string item in Nome)
            {
                Console.WriteLine(item);
            }
        }
        internal void Adicionar_Produto(object adicionar)
        {
            throw new NotImplementedException();
        }

        internal void ListName(object listar)
        {
            throw new NotImplementedException();
        }
    }
}
