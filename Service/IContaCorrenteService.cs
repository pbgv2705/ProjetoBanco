using System;
using System.Collections.Generic;
using System.Text;
using ProjetoBanco.Model;

namespace ProjetoBanco.Service
{
    public interface IContaCorrenteService
    {

        void Sacar(ContaCorrente contaCorrente, double valor);
        void Depositar(ContaCorrente contaCorrente, double valor);
        void Transferir(ContaCorrente contaCorrente, double valor, ContaCorrente contacorrente);
        
    }
}
