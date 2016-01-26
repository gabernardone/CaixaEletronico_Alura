using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico
{
    class ContaInvestimento : OperacoesContas, ITributavel
    {
        public ContaInvestimento(Cliente cliente) : base(cliente)
        {
        }

        public override void Saca(double valor)
        {
            Saldo -= valor;
        }

        public double CalculaTributo()
        {
            return Saldo*0.03;
        }
    }
}
