namespace Prova
{
    partial class CadastroP
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
            btnVoltar = new Button();
            dgvItensPedido = new DataGridView();
            numQuantidade = new NumericUpDown();
            cmbProduto = new ComboBox();
            txtCpfCliente = new TextBox();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnGravar = new Button();
            btnBuscarCliente = new Button();
            label6 = new Label();
            lblTotalPedido = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNomeCliente = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(413, 344);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 29;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Location = new Point(79, 122);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.Size = new Size(404, 107);
            dgvItensPedido.TabIndex = 28;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(322, 84);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(56, 23);
            numQuantidade.TabIndex = 27;
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(123, 83);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(121, 23);
            cmbProduto.TabIndex = 26;
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(107, 46);
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.Size = new Size(100, 23);
            txtCpfCliente.TabIndex = 25;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(395, 84);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 24;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(84, 344);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(99, 23);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir Pedido";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(84, 315);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 23);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar Pedido";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(213, 46);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(75, 23);
            btnBuscarCliente.TabIndex = 21;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 252);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 20;
            label6.Text = "R$";
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(79, 252);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(33, 15);
            lblTotalPedido.TabIndex = 19;
            lblTotalPedido.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 88);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 18;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 88);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 17;
            label3.Text = "Produto";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(290, 50);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(40, 15);
            lblNomeCliente.TabIndex = 16;
            lblNomeCliente.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 50);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 15;
            label1.Text = "CPF";
            // 
            // CadastroP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 405);
            Controls.Add(btnVoltar);
            Controls.Add(dgvItensPedido);
            Controls.Add(numQuantidade);
            Controls.Add(cmbProduto);
            Controls.Add(txtCpfCliente);
            Controls.Add(btnAdicionar);
            Controls.Add(btnExcluir);
            Controls.Add(btnGravar);
            Controls.Add(btnBuscarCliente);
            Controls.Add(label6);
            Controls.Add(lblTotalPedido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNomeCliente);
            Controls.Add(label1);
            Name = "CadastroP";
            Text = "CadastroP";
            Load += CadastroP_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private DataGridView dgvItensPedido;
        private NumericUpDown numQuantidade;
        private ComboBox cmbProduto;
        private TextBox txtCpfCliente;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnGravar;
        private Button btnBuscarCliente;
        private Label label6;
        private Label lblTotalPedido;
        private Label label4;
        private Label label3;
        private Label lblNomeCliente;
        private Label label1;
    }
}