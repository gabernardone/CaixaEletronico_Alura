using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Impostos;
using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico
{
    public partial class frmCaixa : Form
    {
        OperacoesContas[] contas = new OperacoesContas[2];
        public frmCaixa()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Conta mauricio = new Conta();
        //    //Conta guilherme = new Conta();

        //    //mauricio.saldo = 2000.0;
        //    //guilherme.saldo = 1000.0;

        //    //guilherme.Tranfere(100, mauricio);

        //    //MessageBox.Show("O saldo de Guilherme é " + guilherme.saldo);
        //    //MessageBox.Show("O saldo de Mauricio é " + mauricio.saldo);

        //    //Cliente cliente = new Cliente();
        //    //Conta c = new Conta();
        //    //c.Deposita(2200.0);
        //    //cliente.idade = 17;

        //    //// agora vamos testar o saque
        //    //if (c.Saca(2000.0))
        //    //{
        //    //    MessageBox.Show("Saque realizado com sucesso!!");
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Não foi possível realizar a operação de saque");
        //    //}

        //    // Cliente cliente = new Cliente("Gabriel") { Idade = 18 };

        //    // ContaCorrente contaCorrente = new ContaCorrente();
        //    // contaCorrente.Deposita(1200.0);
        //    // contaCorrente.Saca(200.0);

        //    // MessageBox.Show("O Saldo da Conta corrente é " + contaCorrente.Saldo);

        //    // ContaPoupanca contaPoupanca = new ContaPoupanca();
        //    // contaPoupanca.Deposita(1200.0);
        //    // //contaPoupanca.Saca(300.0);

        //    // if (contaPoupanca.Saca(300.0))
        //    // {
        //    //     MessageBox.Show("Saque realizado com sucesso!!");
        //    //     MessageBox.Show("O Saldo da Conta poupança é " + contaPoupanca.Saldo);
        //    // }
        //    // else
        //    // {
        //    //     MessageBox.Show("Não foi possível realizar a operação de saque");
        //    //     MessageBox.Show("O Saldo da Conta poupança é " + contaPoupanca.Saldo);
        //    //}


        //    // TotalizadorContas totalContas = new TotalizadorContas();
        //    // totalContas.Soma(contaCorrente);
        //    // totalContas.Soma(contaPoupanca);

        //    // MessageBox.Show("O saldo total de todas suas contas é de " + totalContas.Total);

        //}

        private OperacoesContas BuscaContaSelecionada()
        {
            int indiceSelecionado = cboConta.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private void MostraConta()
        {
            txtTitular.Text = BuscaContaSelecionada().Cliente.Nome;
            txtNumeroConta.Text = BuscaContaSelecionada().Numero.ToString();
            lblValor.Text = BuscaContaSelecionada().Saldo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            var gabriel = new Cliente("Gabriel", 18);
            var fernanda = new Cliente("Fernanda", 17);

            ContaCorrente contaGabriel = new ContaCorrente(gabriel);
            contaGabriel.Numero = 1;
            contaGabriel.Deposita(1000.0);

            ContaPoupanca contaFernanda = new ContaPoupanca(fernanda);
            contaFernanda.Numero = 2;
            contaFernanda.Deposita(1000.0);


            contas[0] = contaFernanda;
            contas[1] = contaGabriel;

            foreach (OperacoesContas conta in contas)
            {
                cboConta.Items.Add(conta.Cliente.Nome);
                cboDestino.Items.Add(conta.Cliente.Nome);
            }

        }

        private void cboConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscaContaSelecionada();
            MostraConta();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            BuscaContaSelecionada();

            BuscaContaSelecionada().Deposita(double.Parse(txtAcaoValor.Text));
            MostraConta();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            BuscaContaSelecionada();
            BuscaContaSelecionada().Saca(double.Parse(txtAcaoValor.Text));
            MostraConta();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            int indiceContaDestino = cboDestino.SelectedIndex;
            OperacoesContas contaDestino = contas[indiceContaDestino];

            double valorTransferencia = double.Parse(txtAcaoValor.Text);


            BuscaContaSelecionada().Tranfere(valorTransferencia, contaDestino);
            MostraConta();
        }

        private void btnTestes_Click(object sender, EventArgs e)
        {

            var gabriel = new Cliente("Gabriel", 18);
            var fernanda = new Cliente("Fernanda", 17);

            
            ContaPoupanca cp = new ContaPoupanca(gabriel);
            ContaInvestimento ci = new ContaInvestimento(fernanda);
            cp.Deposita(10);
            ci.Deposita(100);

            TotalizadorTributos t = new TotalizadorTributos();
            t.Acumula(ci);
            t.Acumula(cp);

         
            MessageBox.Show("Tributos: " + t.Total);


            GerenciadorImposto gerenciador = new GerenciadorImposto();          
            SeguroDeVida sv = new SeguroDeVida();
            gerenciador.Adiciona(cp);
            gerenciador.Adiciona(sv);
            MessageBox.Show("Total: " + gerenciador.Total);

        }

        public void AdicionaConta(OperacoesContas conta)
        {
            this.contas[conta.TotalContas] = conta;
            cboConta.Items.Add(conta);
        }
    }
}
