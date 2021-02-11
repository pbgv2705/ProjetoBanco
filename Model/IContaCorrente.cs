using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Model
{
    public interface IContaCorrente
    {
        void ObterSaque();
        void ObterDeposito();
        void ObterTransferencia();
        void ObterPix();
    }
}
