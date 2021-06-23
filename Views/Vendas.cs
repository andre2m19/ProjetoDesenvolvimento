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

    
    public partial class Vendas : Form
    {
        Produto  produto;
        private BooKidsContainer4 Vendas_BD;
        public Vendas()
        {
           
            InitializeComponent();
           
 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Instanciar um objecto Home
            home.Show(); // Mostrar Home 
            this.Close();
        }

        private void produtoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {
           
                       

        }
         private void LerDados()
        {
           
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
           
        }

        private void produtoDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
