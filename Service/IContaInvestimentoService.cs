using ProjetoBanco.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Service
{
    public interface IContaInvestimentoService : IBaseService<ContaInvestimento>
    {
        void ResgatarTitulo(ContaInvestimento contaInvestimento);
        void ComprarTitulo(ContaInvestimento contaInvestimento);
        void VenderTitulo(int id);
        List<ContaInvestimento> ObterTodos();
    }
}
