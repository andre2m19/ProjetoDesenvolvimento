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
        private void LerDados()
        {
            listBoxEscolas.DataSource = booKidscontainer4.Escolas.ToList<Escola>();
        }


        private void btn_Registar_Click(object sender, EventArgs e)
        {
            string codPostal = codPostalTextBox.Text;
            string localidade = localidadeTextBox.Text;
            string mail = mailTextBox.Text;
            string morada = moradaTextBox.Text;
            string nome = nomeTextBox.Text;
            string telefone = telefoneTextBox.Text;

            Escola escola = new Escola(nome, morada, telefone, mail, codPostal, localidade);
            booKidscontainer4.Escolas.Add(escola);

            booKidscontainer4.SaveChanges();

            listBoxEscolas.DataSource = null;
            listBoxEscolas.DataSource = booKidscontainer4.Escolas.ToList<Escola>();

            codPostalTextBox.Text = "";
            localidadeTextBox.Text = "";
            mailTextBox.Text = "";
            moradaTextBox.Text = "";
            nomeTextBox.Text = "";
            telefoneTextBox.Text = "";

            MessageBox.Show("Dados Registados!");
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (listBoxEscolas.SelectedIndex == -1)
                return;

            Escola escolaSelecionada = (Escola)listBoxEscolas.SelectedItem;

            booKidscontainer4.Escolas.Remove(escolaSelecionada);


            booKidscontainer4.SaveChanges();

            listBoxEscolas.DataSource = null;
            listBoxEscolas.DataSource = booKidscontainer4.Escolas.ToList<Escola>();

            MessageBox.Show("Dados Apagados!");
        }

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

            booKidscontainer4.SaveChanges();

            MessageBox.Show("Dados Alterados!");
        }

        private void nomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Characters Only!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void codPostalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Number or Digit Only!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void localidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Characters Only!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void telefoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Number or Digit Only!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void localidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void codPostalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailLabel_Click(object sender, EventArgs e)
        {

        }

        private void codPostalLabel_Click(object sender, EventArgs e)
        {

        }

        private void moradaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void localidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void moradaLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}