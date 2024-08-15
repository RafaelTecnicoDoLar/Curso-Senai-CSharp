using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Banco_Santo_Andre
{
    internal class PaginaInicial
    {
        List<Conta> contas;

        public PaginaInicial(List<Conta> contas)
        {
            Console.Clear();
            Console.WriteLine("                   Banco Santo André                       ");
            Console.WriteLine("Bem vindo ao banco Santo André, seu novo banco 100% Digital");
            Console.WriteLine("[1] Abrir Conta");
            Console.WriteLine("[2] Já tem uma conta? Entrar");
            Console.WriteLine("[9] Sair");

            int Randola = Convert.ToInt32(Console.ReadLine());

            switch (Randola)
            {
                case 1:
                    AdicionarConta(contas);
                    break;

                case 2:
                    EntrarConta(contas);
                    break;

                case 69:
                    //Ester Egg
                    Console.WriteLine("Então que dizer que você gosta de bater em mulher?");
                    Thread.Sleep(3000);
                    Console.Write("Ligando para a polícia");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Console.ReadLine();
                    break;

                case 9:
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Dados inválidos, Tente novamente");
                    Console.ReadLine();
                    PaginaInicial paginaInicial;
                    break;
            }
        }

        private void AdicionarConta(List<Conta> contas)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo, cadastre a sua nova conta 100% Digital");

            Console.WriteLine("[1] Conta Corrente");
            Console.WriteLine("[2] Conta Poupança");
            Console.Write("Por favor, informe o Tipo de conta: ");
            int Resposta = Convert.ToInt32(Console.ReadLine());

            Conta novaConta;

            if (Resposta == 1)
            {
                novaConta = new Conta
                {
                    Tipo = 1
                };
            }
            else
            {
                novaConta = new Conta
                {
                    Tipo = 2
                };
            }

            Console.Write("Informe seu nome: ");
            novaConta.Nome = Convert.ToString(Console.ReadLine());

            Console.Write("Como você gostaria de ser chamado? ex: Sr, Sra: ");
            novaConta.Pronome = Convert.ToString(Console.ReadLine());

            Console.Write("Informe seu CPF: ");
            novaConta.CPF = Convert.ToString(Console.ReadLine());

            Console.Write("Informe seu RG: ");
            novaConta.RG = Convert.ToString(Console.ReadLine());

            Console.Write("Informe seu logradouro: ");
            novaConta.Logradouro = Convert.ToString(Console.ReadLine());

            Console.Write("Informe seu bairro: ");
            novaConta.Bairro = Convert.ToString(Console.ReadLine());

            Console.Write("Informe sua cidade: ");
            novaConta.Cidade = Convert.ToString(Console.ReadLine());

            Console.Write("Informe seu estado: ");
            novaConta.Estado = Convert.ToString(Console.ReadLine());

            Console.Write("Informe seu CEP: ");
            novaConta.CEP = Convert.ToString(Console.ReadLine());

            Console.Write("Informe o número do logradouro: ");
            novaConta.numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o número da agência: ");
            novaConta.Agencia = Convert.ToString(Console.ReadLine());

            Console.Write("Informe o número da conta: ");
            novaConta.Numero = Convert.ToString(Console.ReadLine());

            Console.Write("Informe o Saldo inicial: ");
            novaConta.setSaldo(Convert.ToDouble(Console.ReadLine()));

            contas.Add(novaConta);

            Console.WriteLine("Conta cadastrada com sucesso!");
            Console.ReadLine();
            PaginaInicial paginaInicial = new PaginaInicial(contas);
        }

        private void EntrarConta(List<Conta> contas)
        {
            Console.Write("Informe seu CPF: ");
            string cpf = Convert.ToString(Console.ReadLine());

            var conta = contas.FirstOrDefault(c => c.CPF == cpf);

            if (conta != null)
            {
                Console.WriteLine($"Olá {conta.Pronome} {conta.Nome} entrando na conta");
                Movimento movimento = new Movimento(contas);
            }
            else
            {
                Console.WriteLine("Conta não encontrada, verifique as informações e tente novamente");
            }
            Console.ReadLine();
            PaginaInicial paginaInicial = new PaginaInicial(contas);
        }
    }
}