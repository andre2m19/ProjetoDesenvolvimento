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
            booKidscontainer4 = new BooKidsContainer4();
        }
     
        private void Animacao_Load(object sender, EventArgs e)
        {
            booKidscontainer4 = new BooKidsContainer4();
            // Chama a função LerDados
            LerDados();
            
            // Só permite ler as textbox
            nomeTextBox.ReadOnly = true;
            mailTextBox.ReadOnly = true;
            localidadeTextBox.ReadOnly = true;
        }

        // --------------- Popular a listbox --------------------
        private void LerDados()
        {
            listBoxAnimadores.DataSource = booKidscontainer4.Pessoas.OfType<Animador>().ToList<Animador>();

            listBoxPessoas.DataSource = booKidscontainer4.Pessoas.OfType<Cliente>().ToList<Cliente>();
        }

        // --------------- Registar o animador na base de dados --------------

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            if (especialidadeTextBox.Text == "")
            {
                MessageBox.Show("Introduza os dados todos!");
            }
            else
            {
                // Instanciar a Pessoa
                Pessoa pessoaSelecionada = (Pessoa)listBoxPessoas.SelectedItem;

                int idPessoa = pessoaSelecionada.IdPessoa;
                string nome = pessoaSelecionada.Nome;
                string morada = pessoaSelecionada.Morada;
                string localidade = pessoaSelecionada.Localidade;
                string codpostal = pessoaSelecionada.CodPostal;
                string mail = pessoaSelecionada.Mail;
                string especialidade = especialidadeTextBox.Text;
                string telefone = pessoaSelecionada.Telefone;
                string telemovel = pessoaSelecionada.Telemovel;

                // Instanciar Animador
                Animador animador = new Animador(idPessoa, nome, morada, localidade, codpostal, telefone, telemovel, mail, especialidade);

                // Adicionar o Animador
                booKidscontainer4.Pessoas.Add(animador);

                // Guarda as alterações
                booKidscontainer4.SaveChanges();

                // Atualiza a base de dados
                listBoxAnimadores.DataSource = null;
                listBoxAnimadores.DataSource = booKidscontainer4.Pessoas.ToList<Pessoa>();
                
                // Mensagem de aviso
                MessageBox.Show("Especialidade Introduzida!");

                especialidadeTextBox.Text = "";
            }
        }

        
        // ---- Apagar Animador  da base dados
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (listBoxAnimadores.SelectedIndex == -1)
                return;

            Pessoa pessoaSelecionada = (Pessoa)listBoxAnimadores.SelectedItem;

            // Remove um animador
            booKidscontainer4.Pessoas.Remove(pessoaSelecionada);

            // Salva as alterações
            booKidscontainer4.SaveChanges();

            // Atualiza a base de dados
            listBoxAnimadores.DataSource = null;
            listBoxAnimadores.DataSource = booKidscontainer4.Pessoas.ToList<Pessoa>();
        }
     

        // ------------------ Selecionar linha para alterar dados -----------------------
        private void listBoxPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa pessoaSelecionada = (Pessoa)listBoxPessoas.SelectedItem;

            if (listBoxPessoas.SelectedIndex == -1)
                return;

            nomeTextBox.Text = pessoaSelecionada.Nome;
            mailTextBox.Text = pessoaSelecionada.Mail;
            localidadeTextBox.Text = pessoaSelecionada.Localidade;
        }

        // ---- Alterar o animador na base de dados ---------------
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (listBoxAnimadores.SelectedIndex == -1)
                return;

            Animador animadorSelecionado = (Animador)listBoxAnimadores.SelectedItem;

            animadorSelecionado.Especialidade = especialidadeTextBox.Text;

            booKidscontainer4.SaveChanges();

            especialidadeTextBox.Text = "";

            MessageBox.Show("Dados Alterados!");
        }

    }
}