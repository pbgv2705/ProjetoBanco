using ProjetoBanco.Model;
using System;
using System.Globalization;

namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Obter Pix");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new ContaCorrente().ObterSaque();
                    break;

                case '2':
                    new ContaCorrente().ObterDeposito();
                    break;

                case '3':
                    new ContaCorrente().ObterTransferencia();
                    break;

                case '4':
                    new ContaCorrente().ObterPix();
                    break;
            }
        }
    }
}
