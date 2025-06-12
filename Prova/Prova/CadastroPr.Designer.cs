namespace Prova
{
    partial class CadastroPr
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
            btnLimparCamp = new Button();
            btnListar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            dgvProd = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtDescricaoProd = new TextBox();
            txtPrecoProd = new TextBox();
            txtNomeProd = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(308, 395);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 24;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimparCamp
            // 
            btnLimparCamp.Location = new Point(146, 395);
            btnLimparCamp.Name = "btnLimparCamp";
            btnLimparCamp.Size = new Size(118, 23);
            btnLimparCamp.TabIndex = 23;
            btnLimparCamp.Text = "Limpar Campos";
            btnLimparCamp.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(283, 210);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 22;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(202, 210);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(121, 210);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(40, 210);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dgvProd
            // 
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProd.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvProd.Location = new Point(40, 239);
            dgvProd.Name = "dgvProd";
            dgvProd.Size = new Size(343, 150);
            dgvProd.TabIndex = 18;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Preço";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Descrição";
            Column3.Name = "Column3";
            // 
            // txtDescricaoProd
            // 
            txtDescricaoProd.Location = new Point(40, 175);
            txtDescricaoProd.Name = "txtDescricaoProd";
            txtDescricaoProd.Size = new Size(172, 23);
            txtDescricaoProd.TabIndex = 17;
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Location = new Point(40, 106);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.Size = new Size(172, 23);
            txtPrecoProd.TabIndex = 16;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(40, 45);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(172, 23);
            txtNomeProd.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 157);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 14;
            label3.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 13;
            label1.Text = "Nome Do Produto:";
            // 
            // CadastroPr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimparCamp);
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvProd);
            Controls.Add(txtDescricaoProd);
            Controls.Add(txtPrecoProd);
            Controls.Add(txtNomeProd);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CadastroPr";
            Text = "CadastroPr";
            Load += CadastroPr_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnLimparCamp;
        private Button btnListar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private DataGridView dgvProd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtDescricaoProd;
        private TextBox txtPrecoProd;
        private TextBox txtNomeProd;
        private Label label3;
        private Label label1;
    }
}