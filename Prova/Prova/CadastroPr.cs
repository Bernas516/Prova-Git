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
    public partial class CadastroPr : Form
    {
        public CadastroPr()
        {
            InitializeComponent();
        }

        private void CadastroPr_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProd.Text;
            string preco = txtPrecoProd.Text;
            string descricao = txtDescricaoProd.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(preco))
            {
                MessageBox.Show("Nome e Preço são obrigatórios.");
                return;
            }

            string linha = $"{nome};{preco};{descricao}";
            File.AppendAllText("prod.csv", linha + Environment.NewLine);

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProd.Rows.Clear();
            dgvProd.Columns.Clear();

            dgvProd.Columns.Add("Nome", "Nome");
            dgvProd.Columns.Add("Preco", "Preço");
            dgvProd.Columns.Add("Descricao", "Descrição");

            if (File.Exists("prod.csv"))
            {
                var linhas = File.ReadAllLines("prod.csv");

                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length == 3)
                    {
                        dgvProd.Rows.Add(partes[0], partes[1], partes[2]);
                    }
                }
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para atualizar.");
                return;
            }

            int index = dgvProd.SelectedRows[0].Index;
            var linhas = File.ReadAllLines("prod.csv").ToList();

            string novaLinha = $"{txtNomeProd.Text};{txtPrecoProd.Text};{txtDescricaoProd.Text}";
            linhas[index] = novaLinha;

            File.WriteAllLines("prod.csv", linhas);
            MessageBox.Show("Produto atualizado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            int index = dgvProd.SelectedRows[0].Index;
            var linhas = File.ReadAllLines("prod.csv").ToList();
            linhas.RemoveAt(index);
            File.WriteAllLines("prod.csv", linhas);

            MessageBox.Show("Produto excluído com sucesso.");
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNomeProd.Text = dgvProd.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtPrecoProd.Text = dgvProd.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtDescricaoProd.Text = dgvProd.Rows[e.RowIndex].Cells[2].Value?.ToString();
            }
        }

        private void btnLimparCamp_Click(object sender, EventArgs e)
        {
            txtNomeProd.Clear();
            txtPrecoProd.Clear();
            txtDescricaoProd.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormularioP princ = new FormularioP();
            princ.Show();
            this.Hide();
        }
    }
}
