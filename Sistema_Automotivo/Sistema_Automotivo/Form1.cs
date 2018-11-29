using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Automotivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();

            cad.Show();

            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            login log = new login();

            log.Show();
            this.Hide();
        }
    }
}
