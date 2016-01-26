using System;
using System.Collections.Generic;
using System.Linq;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico
{
    class ContaPoupanca : OperacoesContas, ITributavel
    {
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
        }

        public override void Saca(double valor)
        {
            //if (ValidaSaque(valor))
            Saldo -= (valor + 0.10);

            //return ValidaSaque(valor) ? true : false;
        }

        public double CalculaTributo()
        {
            return Saldo*0.02;
        }

    }
}
