using Projeto_DA.Base_de_dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Escolas : Form
    {
        public BooKidsContainer4 booKidscontainer4;
        public Escolas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Instanciar um objecto Home
            home.Show(); // Mostrar Home 
            this.Close();
        }

        private void Escolas_Load(object sender, EventArgs e)
        {
            booKidscontainer4 = new BooKidsContainer4();
            listBoxEscolas.DataSource = booKidscontainer4.Escolas.ToList<Escola>();
            Escola escolaSelecionada = (Escola)listBoxEscolas.SelectedItem;

            if (listBoxEscolas.SelectedIndex == -1)
                return;


            escolaSelecionada.Nome = nomeTextBox.Text;
            escolaSelecionada.CodPostal = codPostalTextBox.Text;
            escolaSelecionada.Localidade = localidadeTextBox.Text;
            escolaSelecionada.Mail = mailTextBox.Text;
            escolaSelecionada.Morada = moradaTextBox.Text;
            escolaSelecionada.Nome = nomeTextBox.Text;
            escolaSelecionada.Telefone = telefoneTextBox.Text;
        }

        // ---- Popular a listbox
        private void LerDados()
        {
            listBoxEscolas.DataSource = booKidscontainer4.Escolas.ToList<Escola>();
        }

        // ------------ Registar a escola na base de dados ------------------
        private void btn_Registar_Click(object sender, EventArgs e)
        {

            if (nomeTextBox.Text== ""  ||codPostalTextBox.Text == "" || localidadeTextBox.Text == "" || mailTextBox.Text == "" || moradaTextBox.Text == "" || telefoneTextBox.Text == "")
            {
                MessageBox.Show("Introduza os dados todos!");
            }
            else { 

            // Declarar variáveis
            string codPostal = codPostalTextBox.Text;
            string localidade = localidadeTextBox.Text;
            string mail = mailTextBox.Text;
            string morada = moradaTextBox.Text;
            string nome = nomeTextBox.Text;
            string telefone = telefoneTextBox.Text;

            // Instanciar a Escola
            Escola escola = new Escola(nome, morada, telefone, mail, codPostal, localidade);
            
            // Adicionar Escola
             booKidscontainer4.Escolas.Add(escola);

            // Salvar alterações
             booKidscontainer4.SaveChanges();

            // Atualiza a base de dados
            listBoxEscolas.DataSource = null;
            listBoxEscolas.DataSource = booKidscontainer4.Escolas.ToList<Escola>();

            // Apaga as Textboxs quando se regista
            codPostalTextBox.Text = "";
            localidadeTextBox.Text = "";
            mailTextBox.Text = "";
            moradaTextBox.Text = "";
            nomeTextBox.Text = "";
            telefoneTextBox.Text = "";

            MessageBox.Show("Dados Registados!");
            }
        }

        // ---------- Apagar a escola da base dados -------------------

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (listBoxEscolas.SelectedIndex == -1)
                return;

            Escola escolaSelecionada = (Escola)listBoxEscolas.SelectedItem;

           // Remove uma Escola
            booKidscontainer4.Escolas.Remove(escolaSelecionada);

            // Salva as alterações
            booKidscontainer4.SaveChanges();

            // Atualiza a base de dados
            listBoxEscolas.DataSource = null;
            listBoxEscolas.DataSource = booKidscontainer4.Escolas.ToList<Escola>();

            MessageBox.Show("Dados Apagados!");
        }

        // ---- Alterar a escola na base de dados
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (listBoxEscolas.SelectedIndex == -1)
                return;

            Escola escolaSelecionada = (Escola)listBoxEscolas.SelectedItem;

            escolaSelecionada.Nome = nomeTextBox.Text;
            escolaSelecionada.CodPostal = codPostalTextBox.Text;
            escolaSelecionada.Localidade = localidadeTextBox.Text;
            escolaSelecionada.Mail = mailTextBox.Text;
            escolaSelecionada.Morada = moradaTextBox.Text;
            escolaSelecionada.Telefone = telefoneTextBox.Text;

            // Guarda as alterações
            booKidscontainer4.SaveChanges();

            MessageBox.Show("Dados Alterados!");
        }

        
        // --------------- Popular as textbox´s -----------------------------
        private void listBoxEscolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEscolas.SelectedIndex == -1)
                return;

            Escola escolaSelecionada = (Escola)listBoxEscolas.SelectedItem;

            nomeTextBox.Text = escolaSelecionada.Nome;
            codPostalTextBox.Text = escolaSelecionada.CodPostal;
            localidadeTextBox.Text = escolaSelecionada.Localidade;
            mailTextBox.Text = escolaSelecionada.Mail;
            moradaTextBox.Text = escolaSelecionada.Morada;
            nomeTextBox.Text = escolaSelecionada.Nome;
            telefoneTextBox.Text = escolaSelecionada.Telefone;
        }

        // ---------------- Limpar as textbox´s -------------------------
        private void buttonClean_Click(object sender, EventArgs e)
        {
            nomeTextBox.Text = "";
            codPostalTextBox.Text = "";
            localidadeTextBox.Text = "";
            mailTextBox.Text = "";
            moradaTextBox.Text = "";
            nomeTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

        // ---------------- Filtragem de letras -----------------------------
        private void telefoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Introduza Números");
            }
        }
    }
}