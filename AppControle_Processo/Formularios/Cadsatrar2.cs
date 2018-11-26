using AppControle_Processo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControle_Processo
{
    public partial class frmCadastrar2 : Form
    {
       
        public frmCadastrar2()
        {
            InitializeComponent();
        }

        private void grpRequerente_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public void Protocolo(int protocolo)
        //{
        //    int numero = 100;
        //    numero += 1;
        //}

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //lblProcesso.Enabled = true;
            //txtNumero.Enabled = true;


            ////
            //int Numero = 100;
            //int Processo;
           
            //try
            //{
            //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\lP3\AppControle_Processo\AppControle_Processo\Dados\Processos.mdf;Integrated Security=True");

            //    using (conn)
            //    {
            //        string cmdString = "";

            //        cmdString = "SELECT * FROM  Processos ORDER BY Numero";

            //        using (SqlCommand cmd = new SqlCommand(cmdString, conn))
            //        {
            //            conn.Open();                                        //Abre a conexão com o banco.
            //            SqlDataReader reader = cmd.ExecuteReader();      //Executa a Query de coleta de dados
            //            while (reader.Read())
            //            {
            //                int.TryParse(reader["Numero"].ToString(), out Numero);
            //            }


            //            conn.Close();
            //        }
            //    }
            //    //incrementa o numero
            //   Processo = Numero + 1;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //


            //adiciona o novo registro na tabela
            try
            {
                if (txtRequerente.Text != string.Empty
                  && txtTel.Text != string.Empty && txtCpf.Text != string.Empty
                   && txtAdv_Requerente.Text != string.Empty && txtRequerido.Text
                  != string.Empty && txtAdv_Requerido.Text != string.Empty &&
                 txtDt_Abertura.Text != string.Empty && txtDescricao.Text != string.Empty)
                {
                    //Instancio o SqlConnection, passando como parâmetro a string de conexão ao banco
                    SqlConnection conn = new SqlConnection
                    (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\lP3\AppControle_Processo\AppControle_Processo\Dados\Processos.mdf;Integrated Security=True");

                    //Instancio o SqlCommand, responsavel pelas instruções SQL e
                    //Passo ao SqlCommand que a conexão que ele usará é o SqlConnection
                    SqlCommand Comm = new SqlCommand("INSERT INTO Processos (Numero, Requerente, " +
                    " Tel_Requerente, cpf, Requerido, Descricao, " +
                    " Adv_Requerido, Adv_Requerente, Dt_Abertura) " +
                    //Nos Values, passo os valores parametricados usado @ para garantir a segurança dos dados
                    " VALUES (@Numero, @Requerente, @Tel_Requerente, @cpf, @Requerido" +
                    " , @Descricao, @Adv_Requerente, @Adv_Requerido, @Dt_Abertura) ");
                    Comm.Connection = conn;

                    //No CommandText do SqlCommand, passo a instrução SQL referenteà Inserção dos dados
                    //Comm.CommandText = "INSERT INTO Processos (Numero, Requerente, " +
                    //" Tel_Requerente, cpf, Requerido, Dt_Abertura, Descricao, " +
                    //" Adv_Requerido, Adv_Requerente) " +
                    ////Nos Values, passo os valores parametricados usado @ para garantir a segurança dos dados
                    //" VALUES (@Numero, @Requerente, @Tel_Requerente, @cpf, @Requerido" +
                    //" @Dt_Abertura, @Descricao, @Adv_Requerente, @Adv_Requerido) ";
                    conn.Open();
                    //Agora passo os Valores parametrizados por meio do metodo AddWithValue
                    // Comm.Parameters.AddWithValue("@Numero", lblNumero.Text);
                    Comm.Parameters.AddWithValue("@Requerente", txtRequerente.Text);
                    Comm.Parameters.AddWithValue("@Numero", txtNumero.Text);
                    Comm.Parameters.AddWithValue("@Dt_Abertura", Convert.ToDateTime(txtDt_Abertura.Text));
                    Comm.Parameters.AddWithValue("@Tel_Requerente", txtTel.Text);
                    Comm.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    Comm.Parameters.AddWithValue("@Requerido", txtRequerido.Text);
                    //Comm.Parameters.AddWithValue("@Dt_Abertura", value: txtDt_Abertura.DataBindings);
                    Comm.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                    Comm.Parameters.AddWithValue("@Adv_Requerente", txtAdv_Requerente.Text);
                    Comm.Parameters.AddWithValue("@Adv_Requerido", txtAdv_Requerido.Text);

                    //Abor a conexão e uso o método ExecuteNonQuery, após isso, fecho a conexão

                    Comm.ExecuteNonQuery();
                    conn.Close();

                    //Exibo uma mensagem ao usuário de inserção realizada com seucesso
                    MessageBox.Show("Dados Inseridos com sucesso!", "mensagem",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Informe os Valores Corretamente para Completar o Cadastro, " +
                      "Somente os Campos Celular e Email Podem Ficar Vazios", "Erro do Sistema",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {



            }
           
            //frmCadastrar2 janela2 = new frmCadastrar2();
           
            //janela2.Show();


            Console.ReadKey();
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {// limpo todas as caixas de textos de um FORM. Você pode colocar 
                //outras condições para verificar outros tipos de componentes do FORM e fazer o que você deseja.
                if (c.GetType().ToString() == "System.Windows.Form.Textbox")
                {
                    c.Text = "";
                }
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //este  codigo fecha a tela atual voltando assim para a tela inicial
            //frmHome janela8 = new frmHome();
            //janela8.Show(); este codigo chama a tela home de novo, com isso acaba duplicando
        }
    }
}
