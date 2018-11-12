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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection
                    (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\lP3\AppControle_Processo\AppControle_Processo\Dados\Processos.mdf;Integrated Security=True");

                //Instancio o SqlCommand, responsavel pelas instruções SQL e
                //Passo ao SqlCommand que a conexão que ele usará é o SqlConnection
                SqlCommand Comm = new SqlCommand();
                Comm.Connection = conn;
                Comm.CommandText = "Select txtPesquisa FROM Processos";
            
                conn.Open();
                Comm.ExecuteNonQuery();
                conn.Close();

                //else
                //{
                //    MessageBox.Show("Informe os Valores Corretamente " +   , "Erro do Sistema",
                //      MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}

            }
            finally
            {
            }
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizar janela1 = new frmAtualizar();
            janela1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastrar2 janela2 = new frmCadastrar2();
            janela2.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAtualizar janela1 = new frmAtualizar();
            janela1.Show();
        }

        private void dtgvVisualizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'processosDataSet1.Processos'. Você pode movê-la ou removê-la conforme necessário.
            //this.processosTableAdapter.Fill(this.processosDataSet1.Processos);

        }

        private void processosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void processosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
