using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Service
{
    public interface IBaseService<Tentity>
    {
        void Salvar(Tentity tentity);
        void Atualizar(Tentity tentity);
        void Apagar(Tentity tentity);
        List<Tentity> ObterTodos();
        
    }
}
