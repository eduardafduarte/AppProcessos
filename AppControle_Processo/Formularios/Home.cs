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
           

     //define a string de conexao com provedor caminho e nome do banco de dados
           string strProvider = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\lP3\AppControle_Processo\AppControle_Processo\Dados\Processos.mdf;Integrated Security=True");


          //  SqlConnection conexao = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\lP3\AppControle_Processo\AppControle_Processo\Dados\Processos.mdf; Integrated Security = True");

          //      conexao.Open();

          ////criando o select e o objeto de consulta
          //string sql = "select * from Processos where Numero='txtPesquisa'";
          //      SqlCommand cmd = new SqlCommand(sql, conexao);
          //      cmd.Connection = conexao;
          //cmd.CommandText = sql;
  
          //// cria o dataadapter...
          //SqlDataAdapter adapter = new SqlDataAdapter();
          //      adapter.SelectCommand = cmd;

          //// preenche o dataset...
          //DataSet dataSet = new DataSet();
          //      adapter.Fill(dataSet);

          //processosDataGridView.DataSource = dataSet;
          //  processosDataGridView.DataMember = dataSet.Tables[0].TableName;
          //conexao.Close();


           // //define a instrução SQL
           string strSql = "SELECT * FROM dbo.Processos where Numero= '"+txtPesquisa.Text+"'";
           //Convert.ToInt16(txtPesquisa.Text);

           // //cria a conexão com o banco de dados
            SqlConnection con = new SqlConnection(strProvider);
           // //cria o objeto command para executar a instruçao sql
           SqlCommand cmd = new SqlCommand(strSql, con);

           // //abre a conexao
           con.Open();

           // //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
           // //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

           // //cria um objeto datatable
            DataTable Processos = new DataTable();

           // //preenche o datatable via dataadapter
           da.Fill(Processos);

           // //atribui o datatable ao datagridview para exibir o resultado
           processosDataGridView.DataSource = Processos;


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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrar2 janela7 = new frmCadastrar2();
            janela7.Show();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
