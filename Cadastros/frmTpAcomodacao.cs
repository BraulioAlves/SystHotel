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
    public partial class frmTpAcomodacao : Form
    {
        public frmTpAcomodacao()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCategoria_Quarto novoQuarto = new frmCategoria_Quarto();
            novoQuarto.ShowDialog();
        }
    }
}
