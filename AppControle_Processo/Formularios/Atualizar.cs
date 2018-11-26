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

namespace AppControle_Processo.Formularios
{
    public partial class frmAtualizar : Form
    {
        public frmAtualizar()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text != string.Empty && txtDt_Movi.Text != string.Empty
                  && txtMovimentacao.Text != string.Empty)

                {
                    SqlConnection conn = new SqlConnection
                        (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\lP3\AppControle_Processo\AppControle_Processo\Dados\Processos.mdf;Integrated Security=True");
                    SqlCommand Comm = new SqlCommand(); 
                    Comm.Connection = conn;

                    Comm.CommandText = "Update Processos SET Dt_Movimentacao= @Dt_Movi, Movimentacao= @Movimentacao WHERE Numero=@Numero";
                    Comm.Parameters.AddWithValue("@Dt_Movi", Convert.ToDateTime(txtDt_Movi.Text));
                    Comm.Parameters.AddWithValue("@Numero", txtNumero.Text);
                    Comm.Parameters.AddWithValue("@Movimentacao", txtMovimentacao.Text);
                    
                    conn.Open();
                    Comm.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Dados ATUALIZADOS com sucesso!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                }
                else
                {
                    MessageBox.Show("Informe os Valores Corretamente para Completar a ATUALIZAÇÃO, " +
                      "Nenhum campo pode ficar em branco", "Erro do Sistema",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
            
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text != string.Empty && txtDt_Movi.Text != string.Empty
                  && txtMovimentacao.Text != string.Empty)

                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\lP3\AppControle_Processo\AppControle_Processo\Dados\Processos.mdf;Integrated Security=True");
                    SqlCommand Comm = new SqlCommand();
                    Comm.Connection = conn;

                    Comm.CommandText = "Update Processos SET( Dt_Movi, Movimentacao) VALUES( @Dt_Movi, @Movimentacao) WHERE (Numero=@Numero))";
                    Comm.Parameters.AddWithValue("@Dt_Movi", Convert.ToDateTime(txtDt_Movi.Text));
                    Comm.Parameters.AddWithValue("@Movimentacao", txtMovimentacao.Text);

                    conn.Open();
                    Comm.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Dados ATUALIZADOS com sucesso!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe os Valores Corretamente para Completar a ATUALIZAÇÃO, " +
                      "Nenhum campo pode ficar em branco", "Erro do Sistema",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            finally
            {
            }
            Console.ReadKey();
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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
