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

        }
    }
}
