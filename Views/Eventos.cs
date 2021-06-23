using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Projeto_DA.Views
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Instanciar um objecto Home
            home.Show(); // Mostrar Home 
            this.Close();
        }

        private void FichaDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cria um ficheiro PDF com o nome Ficha de Inscrições
            using (StreamWriter writer = new StreamWriter("Ficha_de_Inscrições.txt"))
            {
                writer.WriteLine("FICHA DE INSCRIÇÕES");
                writer.WriteLine("Descrição: _________________________________________________");
                writer.WriteLine("Local:  ____________________________________________________");
                writer.WriteLine("Data e Hora: __/__/__  __:__");
                writer.WriteLine("Limite de participação: ___ pessoas");
                writer.WriteLine("Idade inferior:  ____ anos");
                writer.WriteLine("Idade superior:  ____ anos");
                writer.WriteLine("Tipo de evento:  _____________________________________________");

            }
           
        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {

        }
    }
}
