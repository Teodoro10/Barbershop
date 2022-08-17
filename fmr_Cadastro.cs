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
    public partial class fmr_Cadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr; 
        string sql;

        public fmr_Cadastro()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
           

            if (textTelefone.Text == "@Telefone")
            {
                MessageBox.Show("Nome ja esta cadatrado!");
                textTelefone.Focus();
                return;

            }
            if (textCPF.Text == "@CPF")
            {
                MessageBox.Show("CPF ja esta cadatrado!");
                textCPF.Focus();
                return;

            }
            if (textNome.Text == "@Nome")
            {
                MessageBox.Show("Telefone ja esta cadastrado!");
                textNome.Focus();
                return;
            }

            if (textTelefone.Text == "" || textNome.Text == "" || textCPF.Text == "") //OPERADOR OR LÓGICO CONDICIONAL
            {
                MessageBox.Show("Digite todos dos campos!!");
                textTelefone.Focus();
                return;
            }
          

            try

            {
                
                conexao = new MySqlConnection("server=localhost;Database=db_Barbearia;Uid=root;Pwd=;");

                sql = "INSERT INTO barbearia (Nome,CPF, Telefone, Codigo) VALUES (@Nome,@CPF, @Telefone, @Codigo)";

                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@CPF", textCPF.Text);
                comando.Parameters.AddWithValue("@NOME", textTelefone.Text);
                comando.Parameters.AddWithValue("@Telefone", textNome.Text);
                comando.Parameters.AddWithValue("@Codigo", textCodigo.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Gravação Realizada com Sucesso!");

            }
            catch (Exception)
            {

                MessageBox.Show("Cadastro ja existente!");

            }
            finally
            {

                conexao.Close();
                conexao = null;
                comando = null;
                textCPF.Clear();
                textTelefone.Clear();
                textNome.Clear();

                this.textTelefone.Focus();
            }
            fmr_Data objForm2 = new fmr_Data();
            objForm2.Show();
            this.Hide();   // para fazer o button de voltar so mudar o nome do formulario//        
             
        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmenu_Click(object sender, EventArgs e)
        {
            fmr_Menu objForm4 = new fmr_Menu();
            objForm4.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btver2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");

                sql = "SELECT Nome,CPF,Telefone,Codigo FROM barbearia";

                da = new MySqlDataAdapter(sql, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataTable.DataSource = dt;


                conexao.Open();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {

                conexao.Close();
                conexao = null;


                this.textNome.Focus();
            }
        }
    }
}

