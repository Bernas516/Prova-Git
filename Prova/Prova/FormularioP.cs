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
    public partial class FormularioP : Form
    {
        private string usuariologado;
        public FormularioP()
        {
            InitializeComponent();
            usuariologado = usuariologado;
        }

        private void FormularioP_Load(object sender, EventArgs e)
        {

        }

        private void btnCadUsu_Click(object sender, EventArgs e)
        {
            CadastroU usuario = new CadastroU(usuariologado);
        }
    }
}
