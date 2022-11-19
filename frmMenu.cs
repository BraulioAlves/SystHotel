using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystHotel.Cadastros;

namespace SystHotel
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospede novoHospede = new frmHospede();
            novoHospede.MdiParent= this;
            novoHospede.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario novoFuncionario = new frmFuncionario();
            novoFuncionario.MdiParent = this;
            novoFuncionario.Show();
        }

        private void acomodaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTpAcomodacao novaAcomodacao = new frmTpAcomodacao();
            novaAcomodacao.MdiParent = this;
            novaAcomodacao.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduto novoProduto = new frmProduto();
            novoProduto.MdiParent = this;
            novoProduto.Show();
        }

        private void tsbHospede_Click(object sender, EventArgs e)
        {
            frmHospede novoHospede = new frmHospede();
            novoHospede.MdiParent = this;
            novoHospede.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario novoUsuario = new frmUsuario();
            novoUsuario.MdiParent = this;
            novoUsuario.Show();
        }
    }
}
