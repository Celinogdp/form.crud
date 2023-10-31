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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySql = new MySqlConnection("server=Localhost;database=bd_update_1;uid=root;pwd=etec");
            mySql.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO usuario (nome, RG, endereco, telefone) values ('"+ txtNome.Text + "','"+ txtRG.Text + "','"+ txtEndereco.Text +"','"+ txtTelefone.Text +"');", mySql);
            comando.ExecuteNonQuery();

            MessageBox.Show("Aluno registrado com sucesso!!");
            txtNome.Text = "";
            txtRG.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
