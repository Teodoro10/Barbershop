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
    public partial class fmr_Produtos : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string sql;

        public fmr_Produtos()
        {
            InitializeComponent();
        }
        //coloca chave primaria no banco de dados na tabela produtos no codigo
       

        private void textnome_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textcodigo_TextChanged(object sender, EventArgs e)
        {

        }
        //Botao de cadatrar//
        private void btver_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");

               sql = "SELECT Nome, Codigo, Marca, Validade, Quantidade FROM produtos";
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
            }

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            //if (textnome.Text == "")
            //{
            //    MessageBox.Show("Digite o nome do produto");
            //    textnome.Focus();
            //    return;

            //}
            //if (textmarca.Text == "")
            //{
            //    MessageBox.Show("Digite a marca");
            //    textmarca.Focus();
            //    return;

            //}
            //if (textquantidade.Text == "")
            //{
            //    MessageBox.Show("Digite a quantidade");
            //    textquantidade.Focus();
            //    return;

            //}

            if (textnome.Text == "" || textcodigo.Text == "" || textmarca.Text == "" || textvalidade.Text == ""|| textquantidade.Text=="") //OPERADOR OR LÓGICO CONDICIONAL
            {
                MessageBox.Show("Digite todos dos campos!!");
                textnome.Focus();
                return;


            }

            if (textcodigo.Text == "@Codigo")
            {
                MessageBox.Show("Código já exsiste!");
                textcodigo.Focus();
                return;

            }

            try

            {

                conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");

                sql = "INSERT INTO produtos (Nome,Codigo,Marca, Validade, Quantidade) VALUES (@Nome,@Codigo,@Marca,@Validade,@Quantidade)";

                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", textnome.Text);
                comando.Parameters.AddWithValue("@Codigo", textcodigo.Text);
                comando.Parameters.AddWithValue("@Marca", textmarca.Text);
                comando.Parameters.AddWithValue("@Validade", textvalidade.Text);
                comando.Parameters.AddWithValue("@Quantidade", textquantidade.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Gravação Realizada com Sucesso!");

            }
            catch (Exception)
            {

                MessageBox.Show("Produto ja cadastrado");

            }
            finally
            {


                conexao.Close();
                conexao = null;
                comando = null;
                textnome.Clear();
                textmarca.Clear();
                textcodigo.Clear();
                textvalidade.Clear();
                textquantidade.Clear();
                this.textnome.Focus();
            }



        }

        private void btsair_Click(object sender, EventArgs e)
        {
            fmr_Menu objfmr_Menu = new fmr_Menu();
            objfmr_Menu.Show();
            this.Hide();
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (textnome.Text == "" || textcodigo.Text == "" || textmarca.Text == "" || textvalidade.Text == "" || textquantidade.Text == "") //OPERADOR OR LÓGICO CONDICIONAL
            {
                MessageBox.Show("Digite todos dos campos!!");
                textnome.Focus();

            }
            if (textcodigo.Text == "@Codigo")
            {
                MessageBox.Show("produto ja existente");
            }

            try
            {

                MessageBox.Show("Tem certeza que deseja Excluir?");
                textnome.Focus();


                conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");
                sql = "DELETE FROM produtos WHERE Nome = @Nome ";

                comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", textnome.Text);
                comando.Parameters.AddWithValue("@Codigo", textcodigo.Text);
                comando.Parameters.AddWithValue("@Marca", textmarca.Text);
                comando.Parameters.AddWithValue("@Validade", textvalidade.Text);
                comando.Parameters.AddWithValue("@Quantidade", textquantidade.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {

                MessageBox.Show("Produto Excluido!");
                conexao.Close();
                conexao = null;
                comando = null;
                textcodigo.Clear();
                textnome.Clear();
                textquantidade.Clear();
                textmarca.Clear();
                textvalidade.Clear();
                this.textnome.Focus();
            }
        }
    }
}
