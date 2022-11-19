using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystHotel.Cadastros
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
