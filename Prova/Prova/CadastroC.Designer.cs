namespace Prova
{
    partial class CadastroC
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
            btnListarClien = new Button();
            txtWhats = new TextBox();
            txtGmail = new TextBox();
            txtTelef = new TextBox();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            txtBairro = new TextBox();
            txtNum = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtLog = new TextBox();
            txtCEP = new TextBox();
            dgvClientes = new DataGridView();
            btnBuscCEP = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnListarClien
            // 
            btnListarClien.Location = new Point(384, 325);
            btnListarClien.Name = "btnListarClien";
            btnListarClien.Size = new Size(75, 23);
            btnListarClien.TabIndex = 56;
            btnListarClien.Text = "Listar";
            btnListarClien.UseVisualStyleBackColor = true;
            btnListarClien.Click += btnListarClien_Click;
            // 
            // txtWhats
            // 
            txtWhats.Location = new Point(291, 89);
            txtWhats.Name = "txtWhats";
            txtWhats.Size = new Size(100, 23);
            txtWhats.TabIndex = 55;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(98, 90);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(154, 23);
            txtGmail.TabIndex = 54;
            // 
            // txtTelef
            // 
            txtTelef.Location = new Point(439, 30);
            txtTelef.Name = "txtTelef";
            txtTelef.Size = new Size(100, 23);
            txtTelef.TabIndex = 53;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(291, 30);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 52;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 51;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(182, 210);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(143, 23);
            txtBairro.TabIndex = 50;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(101, 210);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(54, 23);
            txtNum.TabIndex = 49;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(351, 210);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(154, 23);
            txtCidade.TabIndex = 48;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(351, 266);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(154, 23);
            txtEstado.TabIndex = 47;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(351, 153);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(154, 23);
            txtLog.TabIndex = 46;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(101, 153);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 45;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(98, 364);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(407, 180);
            dgvClientes.TabIndex = 44;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnBuscCEP
            // 
            btnBuscCEP.Location = new Point(221, 153);
            btnBuscCEP.Name = "btnBuscCEP";
            btnBuscCEP.Size = new Size(75, 23);
            btnBuscCEP.TabIndex = 43;
            btnBuscCEP.Text = "Buscar";
            btnBuscCEP.UseVisualStyleBackColor = true;
            btnBuscCEP.Click += btnBuscCEP_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(291, 325);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 42;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(195, 325);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 41;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(98, 325);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 40;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(351, 248);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 39;
            label11.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(351, 192);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 38;
            label10.Text = "Cidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(182, 192);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 37;
            label9.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 192);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 36;
            label8.Text = "Número:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 135);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 35;
            label7.Text = "Logradouro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 135);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 34;
            label6.Text = "CEP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 71);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 33;
            label5.Text = "WhatsApp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 71);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 32;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 12);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 31;
            label3.Text = "Telefone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 12);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 30;
            label2.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 29;
            label1.Text = "Nome:";
            // 
            // CadastroC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(btnListarClien);
            Controls.Add(txtWhats);
            Controls.Add(txtGmail);
            Controls.Add(txtTelef);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(txtBairro);
            Controls.Add(txtNum);
            Controls.Add(txtCidade);
            Controls.Add(txtEstado);
            Controls.Add(txtLog);
            Controls.Add(txtCEP);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscCEP);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroC";
            Text = "CadastroC";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarClien;
        private TextBox txtWhats;
        private TextBox txtGmail;
        private TextBox txtTelef;
        private TextBox txtCPF;
        private TextBox txtNome;
        private TextBox txtBairro;
        private TextBox txtNum;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private TextBox txtLog;
        private TextBox txtCEP;
        private DataGridView dgvClientes;
        private Button btnBuscCEP;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}