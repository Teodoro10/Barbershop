using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop
{
    public partial class fmr_Menu : Form
    {
        public fmr_Menu()
        {
            InitializeComponent();
        }
        private void Cadastro_Click(object sender, EventArgs e)
        {
            fmr_Cadastro objfmr_Cadastro = new fmr_Cadastro();
            objfmr_Cadastro.Show();
            this.Hide();
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            fmr_Produtos objfmr_Produtos = new fmr_Produtos();
            objfmr_Produtos.Show();
            this.Hide();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Agenda_Click(object sender, EventArgs e)
        {
            fmr_Data objfmr_Data = new fmr_Data();
            objfmr_Data.Show();
            this.Hide();
        }
    }
}
