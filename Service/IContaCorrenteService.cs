using ProjetoBanco.Model;

namespace ProjetoBanco.Service
{
    public interface IContaCorrenteService : IBaseService<ContaCorrente>
    {
        void ChamarSaque();
        void ChamarDeposito();
        void ChamarTransferencia();
    }
}
