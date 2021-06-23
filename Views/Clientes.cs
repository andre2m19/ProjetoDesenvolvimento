using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Projeto_DA.Base_de_dados;

namespace Projeto_DA.Views
{
    public partial class Clientes : Form
    {
        private BooKidsContainer4 meuExemplo;

       
        public Clientes()
        {
            InitializeComponent();
            meuExemplo = new BooKidsContainer4();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Instanciar um objecto Home
            home.Show(); // Mostrar Home 
            this.Close();

        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {

        }
    }
}
