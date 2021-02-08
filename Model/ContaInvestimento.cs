using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco.Model
{
    public class ContaInvestimento : Conta
    {
        public double Valor { get; set; }
        public DateTime DataInvestimento { get; set; }
    }
}
