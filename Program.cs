using System;
using System.Globalization;
using ProjetoBanco.Service;
using ProjetoBanco.Model;

namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine();
                Console.WriteLine("Banco Desafio");

                Console.WriteLine();

                Console.WriteLine(" ..:: Selecione uma opção ::..");
                Console.WriteLine();

                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Transferência");
                Console.WriteLine("5 - Fin");

                var opcao = Console.ReadKey();

                switch (opcao.KeyChar)
                {

                    case '1':
                        new ContaCorrenteService().OperacaoDeposito();
                        break;

                    case '2':
                        new ContaCorrenteService().OperacaoSaque();
                        break;

                    case '3':
                        new ContaCorrenteService().OperacaoTransferencia();
                        break;

                    case '5':
                        a = false;
                        break;
                }
            }
        }
    }
}
