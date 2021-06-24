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
    public partial class Animacao : Form
    {
        public BooKidsContainer4 booKidscontainer4;

        public Animacao()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Home home = new Home(); // Instanciar um objecto Home
            home.Show(); // Mostrar Home  
            this.Close();
        }

        private void Animacao_Load(object sender, EventArgs e)
        {
            booKidscontainer4 = new BooKidsContainer4();
            listBoxAnimadores.DataSource = booKidscontainer4.Pessoas.ToList<Pessoa>();
            listBox1.DataSource = booKidscontainer4.Pessoas.ToList<Pessoa>();

            nomeTextBox.ReadOnly = true;
            mailTextBox.ReadOnly = true;
            localidadeTextBox.ReadOnly = true;

        }

        private void LerDados()
        {
            listBoxAnimadores.DataSource = booKidscontainer4.Pessoas.ToList<Pessoa>();

        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            Pessoa pessoaSelecionada = (Pessoa)listBoxAnimadores.SelectedItem;

            int idPessoa = pessoaSelecionada.IdPessoa;
            string nome = pessoaSelecionada.Nome;
            string morada = pessoaSelecionada.Morada;
            string localidade = pessoaSelecionada.Localidade;
            string codpostal = pessoaSelecionada.CodPostal;
            string mail = pessoaSelecionada.Mail;
            string especialidade = especialidadeTextBox.Text;
            string telefone = pessoaSelecionada.Telefone.ToString();
            string telemovel = pessoaSelecionada.Telemovel.ToString();

            Animador animador = new Animador(idPessoa, nome, morada, localidade, codpostal, telefone, telefone, mail, especialidade);

            booKidscontainer4.Pessoas.Add(animador);

            booKidscontainer4.SaveChanges();

            listBoxAnimadores.DataSource = null;
            listBoxAnimadores.DataSource = booKidscontainer4.Pessoas.ToList<Pessoa>();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (listBoxAnimadores.SelectedIndex == -1)
                return;

            Pessoa pessoaSelecionada = (Pessoa)listBoxAnimadores.SelectedItem;

            booKidscontainer4.Pessoas.Remove(pessoaSelecionada);

            booKidscontainer4.SaveChanges();

            listBoxAnimadores.DataSource = null;
            listBoxAnimadores.DataSource = booKidscontainer4.Pessoas.ToList<Pessoa>();
        }

        private void listBoxAnimadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa pessoaSelecionada = (Pessoa)listBoxAnimadores.SelectedItem;
            Animador animadorSelecionado = (Animador)listBox1.SelectedItem;

            if (listBoxAnimadores.SelectedIndex == -1)
                return;

            nomeTextBox.Text = pessoaSelecionada.Nome;
            mailTextBox.Text = pessoaSelecionada.Mail;
            localidadeTextBox.Text = pessoaSelecionada.Localidade;
            textBoxtelefone.Text = pessoaSelecionada.Telefone;
            especialidadeTextBox.Text = animadorSelecionado.Especialidade;
        }
    }
}