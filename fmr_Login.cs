using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Barbershop
{
    public partial class fmr_Login : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string sql;

        public fmr_Login()
        {
            InitializeComponent();
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            //if (textEmail.Text == "" || textSenha.Text == "")
            //{
            //    MessageBox.Show("Digite em todos os campos");
            //    textEmail.Clear();
            //    textSenha.Clear();
            //    this.textEmail.Focus();
            //}
            //else if (textEmail.Text == "barbearia" || textSenha.Text == "barbearia")
            //{
            //    MessageBox.Show("Seja Bem-Vindo ao sistema");
            //    fmr_Menu objfmr_Menu = new fmr_Menu();
            //    objfmr_Menu.Show();
            //    this.Hide();
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Digitos insiridos estão errados");
            //    textEmail.Clear();
            //    textSenha.Clear();
            //    this.textEmail.Focus();
            //    return;
            //}

            //BOTÃO ENTRAR
            //CHAMA FORMULÁRIO PRINCIPAL




            textEmail.Focus();



            if (textEmail.Text == "" || textSenha.Text == "")
            {



                MessageBox.Show("Digite todos os campos!");
                return;



            }




            conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");
            sql = "SELECT `Email`, `Senha` FROM `login` WHERE Email = @ID and Senha = @SENHA";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@ID", textEmail.Text);
            comando.Parameters.AddWithValue("@SENHA", textSenha.Text);
            conexao.Open();


            //conexao.Open();



            dr = comando.ExecuteReader();



            

            while (dr.Read())
            {
                MessageBox.Show("Você entrou no sistema!!");
                fmr_Menu objfmr_Menu = new fmr_Menu();
                objfmr_Menu.Show();
                this.Hide();
            }


            


            //if (textSenha.Text != "@SENHA" && textEmail.Text != "@ID")
            //{




            //    MessageBox.Show("Usuário não exitente!");
            //    textSenha.Clear();
            //    textEmail.Clear();
            //    textEmail.Focus();

            //}





        }

        private void fmr_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
