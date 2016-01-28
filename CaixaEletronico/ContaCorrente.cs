using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico
{
    class ContaCorrente : OperacoesContas
    {
      
        public override void Saca(double valor)
        {
            //if(ValidaSaque(valor))
            this.Saldo -= valor;
            //return ValidaSaque(valor) ? true : false;
        }

        public ContaCorrente(Cliente cliente) : base(cliente)
        {


        }

        public ContaCorrente()
        {
            
        }
    }
}
