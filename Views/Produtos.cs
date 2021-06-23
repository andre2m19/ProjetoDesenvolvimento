using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Instanciar um objecto Home
            home.Show(); // Mostrar Home
            this.Close();
        }

        private void FichaDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
