using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEletronico.Usuarios
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public byte Idade { get; set; }


        public Cliente(string nome,byte idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Cliente()
        {
        }

        public bool EhMaiorDeIdade()
        {
            return Idade >= 18;
        }

 

    }
}
