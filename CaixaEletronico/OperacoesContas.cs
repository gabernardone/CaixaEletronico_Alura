using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico.Contas
{
    public abstract class OperacoesContas
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public readonly Cliente Cliente;
        


        public enum Tipo
        {
            Corrente,
            Poupanca,
        }

        public OperacoesContas(Cliente cliente)
        {
            Cliente = cliente;
        }

        public abstract void Saca(double valor);
        //{
        //    return ValidaSaque(valor) ? true : false;
        //}

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Tranfere(double valor, OperacoesContas destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        //protected bool ValidaSaque(double valor)
        //{    
        //    if (valor > this.Saldo || valor < 0)
        //    {
        //        return false;
        //    }
        //    if (Cliente.EhMaiorDeIdade())
        //    {
        //        return true;
        //    }
        //    else if (valor <= 200)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
    }
