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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();

            form.Show();
            this.Hide();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            carregarDGV();

        }
        public void limpar() {
            txtNome.Clear();
            txtCPF.Clear();
            txtEnd.Clear();
            txtLog.Clear();
            txtSenha.Clear();
        
        }
        private void insert()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "insert into cliente (nmCliente, cpfCliente,endCliente,flogin,fsenha) values ('" + txtNome.Text + "', '" + txtCPF.Text + "', '" + txtEnd.Text + "', '" + txtLog.Text +"', '"+ txtSenha.Text + "')";

            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);
           
            sqlCommand.ExecuteNonQuery();
            
            MessageBox.Show("Usuário Cadastrado com Sucesso!");

            login log = new login();
            this.Hide();

                log.Show();
           
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtCPF.Text != string.Empty && txtEnd.Text != string.Empty && txtLog.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                insert();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
                limpar();
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        public void carregarDGV(){

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "select idCliente, nmCliente, cpfCliente, endCliente from cliente";
            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dtCad = new DataTable();
            sda.Fill(dtCad);
            dgvCliente.DataSource = dtCad;
            
        }

 

        }

    }

