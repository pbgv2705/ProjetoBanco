using ProjetoBanco.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetoBanco.Service
{
    public class ContaCorrenteService : IContaCorrenteService
    {

        public void ChamarSaque()
        {
            Console.WriteLine();
            Console.Write("Indique seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Indique valor a sacar: ");
            var valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var conta = new ContaCorrente()
            {
                Agencia = 7405,
                Titular = "Paula B.",
                Numero = 789456,
                Saldo = 4500
            };
            var saque = Sacar(conta.Saldo, valor);          
        }
        public void ChamarDeposito()
        {
            Console.WriteLine();
            Console.Write("Indique seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Indique valor a depositar: ");
            var valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var conta = new ContaCorrente()
        {
            Agencia = 7405,
            Titular = "Paula B.",
            Numero = 789456,
            Saldo = 4500
        };
        var deposito = Depositar(conta.Saldo, valor);
    }
    public void ChamarTransferencia()
    {
            Console.WriteLine();
            Console.Write("Indique seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Indique valor a transferir: ");
            var valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var conta = new ContaCorrente()
            {
                Agencia = 7405,
                Titular = "Paula B.",
                Numero = 789456,
                Saldo = 4500
            };
            var contaDestino = new ContaCorrente()
            {
                Agencia = 2705,
                Titular = "Maria",
                Numero = 123654,
                Saldo = 3000
            };

            var transferencia = Transferir(conta.Saldo, valor, contaDestino);          
        }
    private double Sacar(double saldo, double valor)
    {
        if (saldo <= valor)
        {
            Console.WriteLine();
            Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {saldo} é inferior ao valor do saque {valor}");
        }
        else
        {
            saldo -= valor;
            Console.WriteLine();
            Console.WriteLine($"Saque realizado por R$  { valor} Saldo  = R$  {saldo}");
        }
        return saldo;
    }
    private double Depositar(double saldo, double valor)
    {
        saldo += valor;
        Console.WriteLine();
        Console.WriteLine($"Depósito realizado por R$  { valor } Saldo  = R$  { saldo }");
        return saldo;
    }

    private double Transferir(double saldo, double valor, ContaCorrente contaDestino)
    {
        if (saldo >= valor)
        {
            saldo -= valor;
            contaDestino.Saldo += valor;
            Console.WriteLine();
            Console.WriteLine($"Transferência realizada com sucesso por R$ { valor } ");
            Console.WriteLine($"Saldo conta origem  = R$ { saldo } \n Saldo conta destino: { contaDestino.Saldo } ");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Não foi possível concluir a transação. Seu saldo: R$ { saldo } é inferior ao valor do saque: R$ { valor }");
        }
        return saldo;
    }

    public List<ContaCorrente> ObterExtrato()
    {
        throw new NotImplementedException();
    }

        public void Salvar(ContaCorrente tentity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(ContaCorrente tentity)
        {
            throw new NotImplementedException();
        }

        public void Apagar(ContaCorrente tentity)
        {
            throw new NotImplementedException();
        }

        public List<ContaCorrente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
