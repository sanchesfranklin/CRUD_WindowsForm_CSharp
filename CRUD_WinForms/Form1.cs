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

namespace CRUD_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Inicia a conexão com o banco de dados no banco CRUD_SP_DB
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2R9L50L;Initial Catalog=CRUD_SP_DB;Integrated Security=True");

        // Botão para inserir um produto na tabela
        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidaCampos())
            {
                con.Open();

                string status = "";
                if (radioButton1.Checked == true)
                {
                    status = radioButton1.Text;
                }
                else
                {
                    status = radioButton2.Text;
                }
                SqlCommand com = new SqlCommand("exec dbo.SP_InfoProduto_InserirProduto '" + int.Parse(idProduto.Text) + "'," +
                    "'" + nomeProduto.Text + "','" + corProduto.Text + "','" + status + "', '" + DateTime.Parse(dataVencimento.Text) + "'", con);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Salvo com Sucesso!");
                ListarTodosProdutos();
            }        
            
        }

        // Lista todos os produtos, utilizado no Gridview do form
        void ListarTodosProdutos()
        {
            SqlCommand com = new SqlCommand("exec dbo.SP_InfoProduto_ListarProdutos", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarTodosProdutos();
        }

        // Botão para atualizar um produto
        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                con.Open();

                string status = "";
                if (radioButton1.Checked == true)
                {
                    status = radioButton1.Text;
                }
                else
                {
                    status = radioButton2.Text;
                }
                SqlCommand com = new SqlCommand("exec dbo.SP_InfoProduto_AtualizarProduto '" + int.Parse(idProduto.Text) + "'," +
                    "'" + nomeProduto.Text + "','" + corProduto.Text + "','" + status + "', '" + DateTime.Parse(dataVencimento.Text) + "'", con);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualizado com Sucesso!");
                ListarTodosProdutos();
            }
            
        }

        // Botão para deletar um produto
        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidaCampoId())
            {
                if (MessageBox.Show("Tem certeza?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("exec dbo.SP_InfoProduto_DeletarProduto '" + int.Parse(idProduto.Text) + "'", con);

                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deletado com Sucesso!");
                    ListarTodosProdutos();
                }
            }                      

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Botão para listar produto por ID
        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidaCampoId())
            {
                SqlCommand com = new SqlCommand("exec dbo.SP_InfoProduto_ListarProduto_byId'" + int.Parse(idProduto.Text) + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Valida os campos do formulário
        private bool ValidaCampos()
        {
            bool campoValido;

            if (idProduto.Text == "")
            {
                MessageBox.Show("O ID do produto precisa ser informado!");
                idProduto.Focus();
                campoValido = false;
            }
            else if (nomeProduto.Text == "")
            {
                MessageBox.Show("O nome do produto precisa ser informado!");
                nomeProduto.Focus();
                campoValido = false;
            }
            else if (corProduto.Text == "")
            {
                MessageBox.Show("A cor do produto precisa ser informado!");
                corProduto.Focus();
                campoValido = false;
            }
            else
            {
                campoValido = true;
            }

            return campoValido;
        }

        // Método para validar apenas o campo Id do Produto, utilizado no botão Deletar/Search by id
        private bool ValidaCampoId()
        {
            bool campoValido;

            if (idProduto.Text == "")
            {
                MessageBox.Show("O ID do produto precisa ser informado!");
                idProduto.Focus();
                campoValido = false;
            }
            else
            {
                campoValido = true;
            }
            return campoValido;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nomeProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
