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
    public partial class fmr_Data : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string sql;

        public fmr_Data()
        {
            InitializeComponent();
        }

        private void textHorario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (textHorario.Text == "@Horario")
            {
                MessageBox.Show("Horario ja marcado");
                textHorario.Focus();
                return;

            }

            //colocar limite para o horario//

            if (textHorario.Text == "" || textDIa.Text == "" || textMes.Text == "" || textcodigo.Text == "") //OPERADOR OR LÓGICO CONDICIONAL
            {
                MessageBox.Show("Digite todos dos campos!!");
                textHorario.Focus();
                return;


            }

            try

            {

                conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");

                sql = "INSERT INTO date (Mês,Dia, Horario, Codigo) VALUES (@Mês,@Dia, @Horario,@Codigo)";

               comando = new MySqlCommand(sql, conexao);
               comando.Parameters.AddWithValue("@Mês", textMes.Text);
                comando.Parameters.AddWithValue("@Dia", textDIa.Text);
                comando.Parameters.AddWithValue("@Horario", textHorario.Text);
                comando.Parameters.AddWithValue("@Codigo", textcodigo.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Obrigado pela preferencia horario marcado!!");

            }
            catch (Exception)
            {

                MessageBox.Show("Infelizmente horario ja esta marcado");

            }
            finally
            {





                conexao.Close();
                conexao = null;
                comando = null;
                textHorario.Clear();
                textDIa.Clear();
                textMes.Clear();
                textcodigo.Clear();

                this.textHorario.Focus();
            }
        }

        private void textDIa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btver_Click(object sender, EventArgs e) //botao consultar
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");
                
                sql = "SELECT Mês, Dia, Horario,Codigo FROM date";
                
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
               

               this.textHorario.Focus();
            }
        }

        private void btmenu_Click(object sender, EventArgs e)
        {
            fmr_Menu objForm4 = new fmr_Menu();
            objForm4.Show();
            this.Hide();
        }

        private void btExcluit_Click(object sender, EventArgs e)
        {
            //if ( textcodigo.Text == "") //OPERADOR OR LÓGICO CONDICIONAL
            //{
            //    MessageBox.Show("Digite o Código");
            //    textHorario.Focus();

            //}

            if (textHorario.Text == "" || textDIa.Text == "" || textMes.Text == "" || textcodigo.Text == "") //OPERADOR OR LÓGICO CONDICIONAL
            {
                MessageBox.Show("Digite todos dos campos!!");
                textHorario.Focus();
                return;


            }

            try
                {

                    MessageBox.Show("Tem certeza que deseja Excluir?");
                    textHorario.Focus();


                    conexao = new MySqlConnection("server=localhost;Database=db_barbearia;Uid=root;Pwd=;");
                sql = "DELETE FROM date WHERE Codigo = @Codigo ";

                    comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Mês", textMes.Text);
                comando.Parameters.AddWithValue("@Dia", textDIa.Text);
                comando.Parameters.AddWithValue("@Horario", textHorario.Text);
                comando.Parameters.AddWithValue("@Codigo", textcodigo.Text);

                conexao.Open();

                    comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally
                {

                    MessageBox.Show("Cadastro Excluido!");
                    conexao.Close();
                    conexao = null;
                    comando = null;
                    textcodigo.Clear();
                    textDIa.Clear();
                    textMes.Clear();
                    textHorario.Clear();
                    this.textHorario.Focus();
                } 
            
        }

        private void fmr_Data_Load(object sender, EventArgs e)
        {
            
        }
    }
    

}
