using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Home : Form
    {
        Views.Clientes Clientes;
        Views.Animacao Animacao;
        Views.Eventos Eventos;
        Views.Escolas Escolas;
        Views.Produtos Produtos;
        Views.Vendas Vendas;
        public Home()
        {
            InitializeComponent();
        }

        private void pct_Clientes_Click(object sender, EventArgs e)
        {
            //Mostrar o nome da pictureBox
            //[System.ComponentModel.DefaultBindingProperty("Image")]
            //[System.Windows.Forms.Docking(System.Windows.Forms.DockingBehavior.Ask)]
          
            
            Clientes = new Views.Clientes();
            Clientes.Show();
        }
        private void pct_Vendas_Click(object sender, EventArgs e)
        {
            Vendas = new Views.Vendas();
            Vendas.Show();
        }
        private void pct_Eventos_Click(object sender, EventArgs e)
        {
            Eventos = new Views.Eventos();
            Eventos.Show();
        }
        private void pct_Produtos_Click(object sender, EventArgs e)
        {
            Produtos = new Views.Produtos();
            Produtos.Show();
        }
        private void pct_Escolas_Click(object sender, EventArgs e)
        {
            Escolas = new Views.Escolas();
            Escolas.Show();
        }
        private void pct_Animadores_Click(object sender, EventArgs e)
        {
            Animacao = new Views.Animacao();
            Animacao.Show();

        }

       
    }
}
