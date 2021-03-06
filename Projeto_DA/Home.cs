using Projeto_DA.Views;
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

        public Home()
        {
            InitializeComponent();
        }

        //---------- A aplicação inicia com a tela cheia ---------------
        private void Home_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }

        // -------------------- Botão para mostrar o Menú -----------------
        private void btn_showMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
            btn_hideMenu.Show();
            pb_logo.Show();
            btn_showMenu.Hide();

        }

        //--------------------------- Sair -------------------------------
        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //-------- Botões para abrir os formulários dentro de um panel ----
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes janela = new Clientes();
            janela.TopLevel = false;
            janela.Visible = true;
            panel_forms.Controls.Add(janela);


            // ------- Botões Selecionados ------------
            btn_clientes.BackColor = Color.LightBlue;
            btn_animadores.BackColor = Color.Black;
            btn_compras.BackColor = Color.Black;
            btn_escolas.BackColor = Color.Black;
            btn_eventos.BackColor = Color.Black;
            btn_vendas.BackColor = Color.Black;
       
        }        

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            Produtos janela = new Produtos();
            janela.TopLevel = false;
            janela.Visible = true;
            panel_forms.Controls.Add(janela);


            // ------- Botões Selecionados ------------
            btn_clientes.BackColor = Color.Black;
            btn_animadores.BackColor = Color.Black;
            btn_compras.BackColor = Color.Black;
            btn_escolas.BackColor = Color.Black;
            btn_eventos.BackColor = Color.Black;
            btn_vendas.BackColor = Color.LightBlue;
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            // Abre o form dentro do panel que está no Menú
            Eventos janela = new Eventos();
            janela.TopLevel = false;
            janela.Visible = true;
            panel_forms.Controls.Add(janela);

            // ------- Botões Selecionados ------------
            btn_vendas.BackColor = Color.Black;
            btn_clientes.BackColor = Color.Black;
            btn_animadores.BackColor = Color.Black;
            btn_compras.BackColor = Color.Black;
            btn_escolas.BackColor = Color.Black;
            btn_eventos.BackColor = Color.LightBlue;
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            // Abre o form dentro do panel que está no Menú
            Compras janela = new Compras();
            janela.TopLevel = false;
            janela.Visible = true;
            panel_forms.Controls.Add(janela);


            // ------- Botões Selecionados ------------
            btn_vendas.BackColor = Color.Black;
            btn_clientes.BackColor = Color.Black;
            btn_animadores.BackColor = Color.Black;
            btn_compras.BackColor = Color.LightBlue;
            btn_escolas.BackColor = Color.Black;
            btn_eventos.BackColor = Color.Black;
        }

        private void btn_escolas_Click(object sender, EventArgs e)
        {
            // Abre o form dentro do panel que está no Menú
            Escolas janela = new Escolas();
            janela.TopLevel = false;
            janela.Visible = true;
            panel_forms.Controls.Add(janela);


            // ------- Botões Selecionados ------------
            btn_vendas.BackColor = Color.Black;
            btn_clientes.BackColor = Color.Black;
            btn_animadores.BackColor = Color.Black;
            btn_compras.BackColor = Color.Black;
            btn_escolas.BackColor = Color.LightBlue;
            btn_eventos.BackColor = Color.Black;
        }

        private void btn_animadores_Click(object sender, EventArgs e)
        {
            // Abre o form dentro do panel que está no Menú
            Animacao janela = new Animacao();
            janela.TopLevel = false;
            janela.Visible = true;
            panel_forms.Controls.Add(janela);


            // ------- Botões Selecionados ------------
            btn_vendas.BackColor = Color.Black;
            btn_clientes.BackColor = Color.Black;
            btn_animadores.BackColor = Color.LightBlue;
            btn_compras.BackColor = Color.Black;
            btn_escolas.BackColor = Color.Black;
            btn_eventos.BackColor = Color.Black;
        }       
    }
}
