namespace Caelum.CaixaEletronico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cboConta = new System.Windows.Forms.ComboBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.txtAcaoValor = new System.Windows.Forms.TextBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.lblAcao = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestes = new System.Windows.Forms.Button();
            this.gpbMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(4, 55);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(89, 23);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(12, 137);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(15, 153);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(224, 20);
            this.txtTitular.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 81);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(90, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número da Conta";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(15, 101);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(83, 20);
            this.txtNumeroConta.TabIndex = 8;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(9, 252);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(86, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo disponível";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(9, 269);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(101, 18);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Saldo Conta";
            // 
            // cboConta
            // 
            this.cboConta.FormattingEnabled = true;
            this.cboConta.Location = new System.Drawing.Point(7, 31);
            this.cboConta.Name = "cboConta";
            this.cboConta.Size = new System.Drawing.Size(121, 21);
            this.cboConta.TabIndex = 10;
            this.cboConta.SelectedIndexChanged += new System.EventHandler(this.cboConta_SelectedIndexChanged);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(4, 25);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(89, 23);
            this.btnDepositar.TabIndex = 11;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.btnTestes);
            this.gpbMenu.Controls.Add(this.btnTransferir);
            this.gpbMenu.Controls.Add(this.btnDepositar);
            this.gpbMenu.Controls.Add(this.btnSacar);
            this.gpbMenu.Location = new System.Drawing.Point(324, 12);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(97, 265);
            this.gpbMenu.TabIndex = 12;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(4, 84);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(89, 23);
            this.btnTransferir.TabIndex = 12;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // txtAcaoValor
            // 
            this.txtAcaoValor.Location = new System.Drawing.Point(94, 203);
            this.txtAcaoValor.Name = "txtAcaoValor";
            this.txtAcaoValor.Size = new System.Drawing.Size(100, 20);
            this.txtAcaoValor.TabIndex = 13;
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(177, 32);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(121, 21);
            this.cboDestino.TabIndex = 15;
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Location = new System.Drawing.Point(91, 187);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(31, 13);
            this.lblAcao.TabIndex = 16;
            this.lblAcao.Text = "Valor";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(4, 16);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 13);
            this.lblOrigem.TabIndex = 17;
            this.lblOrigem.Text = "Origem";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(176, 16);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 18;
            this.lblDestino.Text = "Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboConta);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.cboDestino);
            this.groupBox1.Controls.Add(this.lblOrigem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 59);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transferência";
            // 
            // btnTestes
            // 
            this.btnTestes.Location = new System.Drawing.Point(4, 113);
            this.btnTestes.Name = "btnTestes";
            this.btnTestes.Size = new System.Drawing.Size(89, 23);
            this.btnTestes.TabIndex = 13;
            this.btnTestes.Text = "Testes";
            this.btnTestes.UseVisualStyleBackColor = true;
            this.btnTestes.Click += new System.EventHandler(this.btnTestes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 289);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAcao);
            this.Controls.Add(this.txtAcaoValor);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cboConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox txtAcaoValor;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestes;
    }
}

