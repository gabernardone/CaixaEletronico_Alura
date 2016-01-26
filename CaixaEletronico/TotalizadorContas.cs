using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.CaixaEletronico.Contas;

namespace Caelum.CaixaEletronico
{
    class TotalizadorContas
    {
        public double Total { get; private set; }

        public void Soma(OperacoesContas conta)
        {
            Total += conta.Saldo;
            
        }


    }
}
