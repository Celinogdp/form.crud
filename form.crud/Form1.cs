using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace form.crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void CarregarDadosBanco()
        {
            string conexao = "server=Localhost;database=bd_update_1;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);

            try
            {
                conexaoMYSQL.Open();

                MySqlDataAdapter adapter = null;

                DataTable dataTable = new DataTable();

                using (MySqlCommand comando = new MySqlCommand("select * from usuario", conexaoMYSQL))
                {
                    adapter = new MySqlDataAdapter(comando);
                    adapter.Fill(dataTable);

                    dgvAluno.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (conexaoMYSQL.State == ConnectionState.Open)
                {
                    conexaoMYSQL.Close();
                }
                conexaoMYSQL.Dispose();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=bd_update_1;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            try
            {
                conexaoMYSQL.Open();

                using (MySqlCommand comando = new MySqlCommand($"update usuario set nome='{txtNome.Text}', RG='{txtRG.Text}', endereco='{txtEndereco.Text}', telefone='{txtTelefone.Text}' where id={txtID.Text}", conexaoMYSQL))
                {
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados alterados!!!");

                    txtID.Text = "";
                    txtNome.Text = "";
                    txtRG.Text = "";
                    txtEndereco.Text = "";
                    txtTelefone.Text = "";

                    pnlAlterar.Visible = false;

                    CarregarDadosBanco();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (conexaoMYSQL.State == ConnectionState.Open)
                {
                    conexaoMYSQL.Close();
                }
                conexaoMYSQL.Dispose();
            }
        }

        private void dgvAluno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRG.Text = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEndereco.Text = dgvAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelefone.Text = dgvAluno.Rows[e.RowIndex].Cells[4].Value.ToString();

            pnlAlterar.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult caixaMensagem = MessageBox.Show("Deseja realmente exluir esse aluno?", "Etec Taboão da Serra", MessageBoxButtons.YesNo);

            if (caixaMensagem == DialogResult.Yes)
            {
                string conexao = "server=localhost;database=bd_update_1;uid=root;pwd=etec";
                MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);

                try
                {
                    conexaoMYSQL.Open();

                    using (MySqlCommand comando = new MySqlCommand($"delete from usuario where id={txtID.Text}", conexaoMYSQL))
                    {
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados excluídos!!!");

                        txtID.Text = "";
                        txtNome.Text = "";
                        txtRG.Text = "";
                        txtEndereco.Text = "";
                        txtTelefone.Text = "";

                        pnlAlterar.Visible = false;

                        CarregarDadosBanco();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    if (conexaoMYSQL.State == ConnectionState.Open)
                    {
                        conexaoMYSQL.Close();
                    }
                    conexaoMYSQL.Dispose();
                }
            }
        }
    }
}