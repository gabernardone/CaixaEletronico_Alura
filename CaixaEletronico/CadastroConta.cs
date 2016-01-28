using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caelum.CaixaEletronico;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Impostos;
using Caelum.CaixaEletronico.Usuarios;

namespace CaixaEletronico
{
    public partial class frmCadastroConta : Form
    {
        private frmCaixa aplicacaoPrincipal;
        public frmCadastroConta(frmCaixa aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            OperacoesContas contaSelecionata = (OperacoesContas) cboTipo.SelectedItem;


            ContaCorrente cc = new ContaCorrente();
            cc.Numero = int.Parse(txtNumero.Text);
                
            //aplicacaoPrincipal.AdicionaConta(conta);

        }
    }
}
