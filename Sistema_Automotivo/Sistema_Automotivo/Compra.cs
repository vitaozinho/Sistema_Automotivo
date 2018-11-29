using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Automotivo
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtcor.Clear();
            txtAno.Clear();
        }

        private void combomarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(combomarcas.SelectedValue.ToString());
                carregarComboModelos();
            }
            catch { }
        }

        private void carregarComboMarcas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "select * from marca";
            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dtMarca = new DataTable();
            sda.Fill(dtMarca);

            combomarcas.DataSource = dtMarca;
            combomarcas.DisplayMember = "nmMarca";
            combomarcas.ValueMember = "idMarca";
        }

        private void carregarComboModelos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "select * from modelo where idMarca ='" + combomarcas.SelectedValue + "' ";
            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dtModelo = new DataTable();
            sda.Fill(dtModelo);

            combomodelos.DataSource = dtModelo;
            combomodelos.DisplayMember = "nmModelo";
        }



        private void Compra_Load(object sender, EventArgs e)
        {
            carregarComboMarcas();
            carregarComboModelos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();

            form.Show();
            this.Hide();
        }

        private void combomodelos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comprar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "insert into vendas (marca, modelo, cor, ano) values ('" + combomarcas.Text + "', '" + combomodelos.Text + "', '" + txtcor.Text + "', '" + txtAno.Text + "')";

            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Compra efetuada!");

            limpar();

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            comprar();
        }
        private void limpar() {
            carregarComboMarcas();
            carregarComboModelos();
            txtAno.Clear();
            txtcor.Clear();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
