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
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from usuario", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAluno.DataSource = dt;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=bd_update_1;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update usuario set nome='" + txtNome.Text + "', RG='" + txtRG.Text + "', endereco='" + txtEndereco.Text +"', telefone='" + txtTelefone.Text + "' where id=" + txtID.Text, conexaoMYSQL);
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

        private void dgvAluno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRG.Text = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEndereco.Text = dgvAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelefone.Text = dgvAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
            pnlAlterar.Visible = true;
        }

        private void pnlAlterar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();

        }
    }
}
