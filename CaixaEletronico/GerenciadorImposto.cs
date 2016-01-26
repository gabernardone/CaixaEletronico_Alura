using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEletronico.Impostos
{
    class GerenciadorImposto
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel tributavel)
        {
            Total += tributavel.CalculaTributo();
        }
    }
}
