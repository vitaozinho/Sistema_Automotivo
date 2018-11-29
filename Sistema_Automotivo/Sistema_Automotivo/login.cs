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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void btnlogar_Click(object sender, EventArgs e)
        {
          
        }
      

        public void limpar()
        {
            txtsenha.Clear();
            txtusuario.Clear();

        }


        private void verificar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "select * from cliente where flogin = '" + txtusuario.Text + "' and fsenha = '" + txtsenha.Text + "' ";
            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dtLogin = new DataTable();
            sda.Fill(dtLogin);
            if (dtLogin.Rows.Count == 1)
            {
                MessageBox.Show("Bem Vindo '" + txtusuario.Text + "'!");

                Compra compra = new Compra();
                this.Hide();

                compra.Show();
            }

            else
            {
                MessageBox.Show("Usario ou senha invalidos");
            }
        }
                
        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != string.Empty && txtsenha.Text != string.Empty)
            {
                verificar();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpar();
        }

      

    }
}
