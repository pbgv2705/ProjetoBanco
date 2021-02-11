using System;

namespace ProjetoBanco.Model
{
    public class ContaCorrente : IContaCorrente
    {
        public void ObterSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o valor para saque: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            Conta conta = new Conta()
            {
                Agencia = 14,
                Id = 01,
                NumeroConta = 7684,
                Saldo = 2500
            };

            Sacar(conta, valor);

        }

        public void ObterDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o valor a depositar: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            Conta conta = new Conta()
            {
                Agencia = 14,
                Id = 01,
                NumeroConta = 7684,
                Saldo = 2500
            };

            var deposito = Depositar(conta, valor);
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Depósito realizado com sucesso. Saldo da sua conta é de: {conta.Saldo}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
        }

        public void ObterTransferencia()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o valor para transferência: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            Conta conta = new Conta()
            {
                Agencia = 14,
                Id = 01,
                NumeroConta = 7684,
                Saldo = 2500
            };
            Conta contaDestino = new Conta()
            {
                Agencia = 73,
                Id = 15,
                NumeroConta = 2574,
                Saldo = 3000
            };

            Transferir(conta, valor, contaDestino);
        }

        public void ObterPix()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine(" ..:: Selecione uma opção para sua chave Pix::..");
            Console.WriteLine();
            Console.WriteLine("1 - CPF");
            Console.WriteLine("2 - e-mail");
            Console.WriteLine("3 - celular");

            var opcao = Console.ReadKey();
            string chave;
            Conta conta = new Conta()
            {
                Agencia = 14,
                Id = 01,
                NumeroConta = 7684,
                Saldo = 2500
            };
            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine("Indique seu CPF: " + "\n");
                    chave = Console.ReadLine();
                    Console.WriteLine($"Pix da conta {conta.Agencia} - {conta.NumeroConta} cadastrado com sucesso {chave}");
                    break;
                case '2':
                    Console.WriteLine("Indique seu e-mail: " + "\n");
                    chave = Console.ReadLine();
                    Console.WriteLine($"Pix da conta {conta.Agencia} - {conta.NumeroConta} cadastrado com sucesso {chave}");
                    break;
                case '3':
                    Console.WriteLine("Indique seu telefone: " + "\n");
                    chave = Console.ReadLine();
                    Console.WriteLine($"Pix da conta {conta.Agencia} - {conta.NumeroConta} cadastrado com sucesso {chave}");
                    break;
            }
            
        }

            private void Sacar(Conta conta, double valor)
        {
            if (valor > conta.Saldo)
            {
                Console.WriteLine($"Valor saldo: {conta.Saldo} é inferior");
            }
            else
            {
                conta.Saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso. Saldo da sua conta é de: {conta.Saldo}" + "\n");
                
            }
        }
        private double Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor;
            return conta.Saldo;
        }
        private void Transferir(Conta conta, double valor, Conta contaDestino)
        {
            if (valor > conta.Saldo)
            {
                Console.WriteLine($"Valor saldo: {conta.Saldo} é inferior");
            }
            else
            {
                conta.Saldo -= valor;
                contaDestino.Saldo += valor;
                Console.WriteLine($"Transferência realizado com sucesso. Saldo da sua conta é de: {conta.Saldo}" +"\n");
                Console.WriteLine($"Saldo da conta destino: {contaDestino.Saldo}");
            }
        }
    }
}
