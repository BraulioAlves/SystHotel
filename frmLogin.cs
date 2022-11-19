using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystHotel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            pictureBox2.BackgroundImage = Properties.Resources.Usuarios;
            panel1.ForeColor = Color.FromArgb(34, 35, 130);
            txtUsuario.ForeColor = Color.FromArgb(34, 35, 130);

            pictureBox3.BackgroundImage = Properties.Resources.Senha;
            panel2.ForeColor = Color.WhiteSmoke;
            txtUsuario.ForeColor = Color.WhiteSmoke;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtSenha.PasswordChar= '*';
            pictureBox3.BackgroundImage = Properties.Resources.Senha;
            panel1.ForeColor = Color.FromArgb(34, 35, 130);
            txtUsuario.ForeColor = Color.FromArgb(34, 35, 130);

            pictureBox2.BackgroundImage = Properties.Resources.Usuarios;
            panel2.ForeColor = Color.WhiteSmoke;
            txtUsuario.ForeColor = Color.WhiteSmoke;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        private void ChamarLogin()
        {
            if (txtUsuario.Text == "0" || txtSenha.Text == "0")
            {
                MessageBox.Show("Preencha os Campos");
            }
            else
            {
                frmMenu novoMenu = new frmMenu();
                this.Hide();
                novoMenu.Show();
            }
        }
    }
}
