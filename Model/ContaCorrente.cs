using ProjetoBanco.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Model
{
    public class ContaCorrente : Conta
    {     
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente()
        {
            // Não estou usando eles ... Quando os uso???
        }
        public ContaCorrente(string titular, int agencia, int numero, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
        }
    }

  
}
