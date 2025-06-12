namespace Prova
{
    partial class FormularioP
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
            btnCadPed = new Button();
            btnCadProduto = new Button();
            btnCadCliente = new Button();
            btnCadUsu = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(97, 96);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(148, 23);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCadPed
            // 
            btnCadPed.Location = new Point(169, 50);
            btnCadPed.Name = "btnCadPed";
            btnCadPed.Size = new Size(141, 23);
            btnCadPed.TabIndex = 8;
            btnCadPed.Text = "Cadastro de Pedidos";
            btnCadPed.UseVisualStyleBackColor = true;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(12, 50);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(151, 23);
            btnCadProduto.TabIndex = 7;
            btnCadProduto.Text = "Cadastro de Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // btnCadCliente
            // 
            btnCadCliente.Location = new Point(169, 12);
            btnCadCliente.Name = "btnCadCliente";
            btnCadCliente.Size = new Size(141, 23);
            btnCadCliente.TabIndex = 6;
            btnCadCliente.Text = "Cadastro de Cliente";
            btnCadCliente.UseVisualStyleBackColor = true;
            btnCadCliente.Click += btnCadCliente_Click;
            // 
            // btnCadUsu
            // 
            btnCadUsu.Location = new Point(12, 12);
            btnCadUsu.Name = "btnCadUsu";
            btnCadUsu.Size = new Size(151, 23);
            btnCadUsu.TabIndex = 5;
            btnCadUsu.Text = "Cadastro de Usuário";
            btnCadUsu.UseVisualStyleBackColor = true;
            btnCadUsu.Click += btnCadUsu_Click;
            // 
            // FormularioP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 134);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadPed);
            Controls.Add(btnCadProduto);
            Controls.Add(btnCadCliente);
            Controls.Add(btnCadUsu);
            Name = "FormularioP";
            Text = "FormularioP";
            Load += FormularioP_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private Button btnCadPed;
        private Button btnCadProduto;
        private Button btnCadCliente;
        private Button btnCadUsu;
    }
}