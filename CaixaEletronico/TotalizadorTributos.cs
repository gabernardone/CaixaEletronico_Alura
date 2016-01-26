using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.CaixaEletronico;

namespace Caelum.CaixaEletronico.Impostos
{
    class TotalizadorTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel tributavel)
        {
            Total += tributavel.CalculaTributo();
        }

    }
}
