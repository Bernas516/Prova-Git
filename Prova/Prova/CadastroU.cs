using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class CadastroU : Form
    {
        private string usuariologado;
        public CadastroU()
        {
            InitializeComponent();
        }

        public CadastroU(string usuariologado)
        {
            InitializeComponent();
            this.usuariologado = usuariologado;
        }

        private void CadastroU_Load(object sender, EventArgs e)
        {
            string path = "Usu.csv";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "ADMIN;123\n");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormularioP princi = new FormularioP();
            princi.ShowDialog();
            this.Hide();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (usuariologado != "ADMIN")
            {
                MessageBox.Show("Apenas o ADMIN pode cadastrar usuários.");
                return;
            }

            string usuario = txtNomeUsu.Text.Trim().ToLower();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            var linhas = File.ReadAllLines("Usu.csv").ToList();
            if (linhas.Any(l => l.Split(';')[0] == usuario))
            {
                MessageBox.Show("Usuário já existe.");
                return;
            }

            linhas.Add($"{usuario};{senha}");
            File.WriteAllLines("Usu.csv", linhas);
            MessageBox.Show("Usuário cadastrado com sucesso.");
        }

        private void dgvUsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsu.Rows.Clear();
            dgvUsu.Columns.Clear();
            dgvUsu.Columns.Add("Usuario", "Senha");

            var linhas = File.ReadAllLines("Usu.csv");
            foreach (var linha in linhas)
            {
                string[] partes = linha.Split(';');
                dgvUsu.Rows.Add(partes[0]);
            }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            if (dgvUsu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário.");
                return;
            }

            string usuario = dgvUsu.SelectedRows[0].Cells[0].Value.ToString();
            if (usuario == "ADMIN")
            {
                MessageBox.Show("Não é permitido excluir o ADMIN.");
                return;
            }

            var linhas = File.ReadAllLines("Usu.csv").ToList();
            linhas = linhas.Where(l => !l.StartsWith(usuario + ";")).ToList();
            File.WriteAllLines("Usu.csv", linhas);
            MessageBox.Show("Usuário excluído.");
        }

        private void btnAltSen_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNewSenha.Text.Trim();
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Digite a nova senha.");
                return;
            }

            var linhas = File.ReadAllLines("Usu.csv").ToList();
            for (int i = 0; i < linhas.Count; i++)
            {
                string[] partes = linhas[i].Split(';');
                if (partes[0] == usuariologado)
                {
                    linhas[i] = $"{usuariologado};{novaSenha}";
                    File.WriteAllLines("Usu.csv", linhas);
                    MessageBox.Show("Senha alterada.");
                    return;
                }
            }
            MessageBox.Show("Usuário não encontrado.");
        }
    }
}
