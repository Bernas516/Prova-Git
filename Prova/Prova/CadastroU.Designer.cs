namespace Prova
{
    partial class CadastroU
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
            dgvUsu = new DataGridView();
            btnVoltar = new Button();
            btnAltSen = new Button();
            btnExc = new Button();
            btnCad = new Button();
            txtNewSenha = new TextBox();
            txtSenha = new TextBox();
            txtNomeUsu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsu).BeginInit();
            SuspendLayout();
            // 
            // dgvUsu
            // 
            dgvUsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsu.Location = new Point(162, 51);
            dgvUsu.Name = "dgvUsu";
            dgvUsu.Size = new Size(285, 150);
            dgvUsu.TabIndex = 22;
            dgvUsu.CellContentClick += dgvUsu_CellContentClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(348, 268);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(99, 23);
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAltSen
            // 
            btnAltSen.Location = new Point(348, 207);
            btnAltSen.Name = "btnAltSen";
            btnAltSen.Size = new Size(99, 23);
            btnAltSen.TabIndex = 20;
            btnAltSen.Text = "Alterar Senha";
            btnAltSen.UseVisualStyleBackColor = true;
            btnAltSen.Click += btnAltSen_Click;
            // 
            // btnExc
            // 
            btnExc.Location = new Point(254, 207);
            btnExc.Name = "btnExc";
            btnExc.Size = new Size(75, 23);
            btnExc.TabIndex = 19;
            btnExc.Text = "Excluir";
            btnExc.UseVisualStyleBackColor = true;
            btnExc.Click += btnExc_Click;
            // 
            // btnCad
            // 
            btnCad.Location = new Point(162, 207);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(75, 23);
            btnCad.TabIndex = 18;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = true;
            btnCad.Click += btnCad_Click;
            // 
            // txtNewSenha
            // 
            txtNewSenha.Location = new Point(28, 152);
            txtNewSenha.Name = "txtNewSenha";
            txtNewSenha.Size = new Size(100, 23);
            txtNewSenha.TabIndex = 17;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(28, 99);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 16;
            // 
            // txtNomeUsu
            // 
            txtNomeUsu.Location = new Point(28, 51);
            txtNomeUsu.Name = "txtNomeUsu";
            txtNomeUsu.Size = new Size(100, 23);
            txtNomeUsu.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 134);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 14;
            label3.Text = "Nova Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 13;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome De Usuário:";
            // 
            // CadastroU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 310);
            Controls.Add(dgvUsu);
            Controls.Add(btnVoltar);
            Controls.Add(btnAltSen);
            Controls.Add(btnExc);
            Controls.Add(btnCad);
            Controls.Add(txtNewSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeUsu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroU";
            Text = "CadastroU";
            Load += CadastroU_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsu;
        private Button btnVoltar;
        private Button btnAltSen;
        private Button btnExc;
        private Button btnCad;
        private TextBox txtNewSenha;
        private TextBox txtSenha;
        private TextBox txtNomeUsu;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}