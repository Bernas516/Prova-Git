using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Prova
{
    public partial class CadastroC : Form
    {
        public CadastroC()
        {
            InitializeComponent();
        }

        private void btnBuscCEP_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim().Replace("-", "").Replace(".", "");
            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    var resposta = await client.GetAsync(url);
                    if (resposta.IsSuccessStatusCode)
                    {
                        string json = await resposta.Content.ReadAsStringAsync();
                        dynamic endereco = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                        if (endereco.erro != null)
                        {
                            MessageBox.Show("CEP não encontrado.");
                            return;
                        }

                        txtLog.Text = endereco.logradouro;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.localidade;
                        txtEstado.Text = endereco.uf;
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao consultar o CEP.");
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtCPF.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtGmail.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value?.ToString();
                txtTelef.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value?.ToString();
                txtWhats.Text = dgvClientes.Rows[e.RowIndex].Cells[4].Value?.ToString();
                txtCEP.Text = dgvClientes.Rows[e.RowIndex].Cells[5].Value?.ToString();
                txtLog.Text = dgvClientes.Rows[e.RowIndex].Cells[6].Value?.ToString();
                txtNum.Text = dgvClientes.Rows[e.RowIndex].Cells[7].Value?.ToString();
                txtBairro.Text = dgvClientes.Rows[e.RowIndex].Cells[8].Value?.ToString();
                txtCidade.Text = dgvClientes.Rows[e.RowIndex].Cells[9].Value?.ToString();
                txtEstado.Text = dgvClientes.Rows[e.RowIndex].Cells[10].Value?.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string linha = $"{txtNome.Text};{txtCPF.Text};{txtGmail.Text};{txtTelef.Text};{txtWhats.Text};{txtCEP.Text};{txtLog.Text};{txtNum.Text};{txtBairro.Text};{txtCidade.Text};{txtEstado.Text}";

            File.AppendAllText("Cliente.csv ", linha + Environment.NewLine);
            MessageBox.Show("Cliente salvo com sucesso!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnListarClien_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("Nome", "Nome");
            dgvClientes.Columns.Add("CPF", "CPF");
            dgvClientes.Columns.Add("Email", "Email");
            dgvClientes.Columns.Add("Telefone", "Telefone");
            dgvClientes.Columns.Add("Whatsapp", "WhatsApp");

            if (File.Exists("Cliente.csv"))
            {
                var linhas = File.ReadAllLines("Cliente.csv");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    if (campos.Length == 10)
                    {
                        dgvClientes.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], campos[6], campos[7], campos[8], campos[9], campos[10]);
                    }
                    dgvClientes.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], campos[6], campos[7], campos[8], campos[9], campos[10]);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
