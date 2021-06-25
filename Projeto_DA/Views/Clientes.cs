using Projeto_DA.Base_de_dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace Projeto_DA.Views
{

    public partial class Clientes : Form
    {
        public BooKidsContainer4 booKidsContainer4;

        public Clientes()
        {
            InitializeComponent();
            booKidsContainer4 = new BooKidsContainer4();

        }


        // ----------------- Criar cliente -----------------------
        private void btn_Registar_Click(object sender, EventArgs e)
        {
            if (tb_codpostal.Text == "" || tb_localidade.Text == "" || tb_mail.Text == "" || tb_morada.Text == "" || tb_nome.Text == "" || tb_Nrcartao.Text == "" || tb_telefone.Text == "" || tb_telemovel.Text == "" || tb_Valoroferta.Text == "")
            {
                MessageBox.Show("Introduza os dados todos!");
            }
            else
            {
                // Declarar variáveis
                string Nome = tb_nome.Text;
                string Morada = tb_morada.Text;
                string Localidade = tb_localidade.Text;
                string CodPostal = tb_codpostal.Text;
                string Telefone = tb_telefone.Text;
                string Telemovel = tb_telemovel.Text;
                string Mail = tb_mail.Text;
                string Nr_cartao = tb_Nrcartao.Text;
                string Valor_oferta = tb_Valoroferta.Text;

            // Instanciar o Cliente
            Cliente cliente = new Cliente(Nome, Morada, Localidade, CodPostal, Telefone, Telemovel, Mail, Nr_cartao, Valor_oferta);
           
            // Adiciona o cliente
            booKidsContainer4.Pessoas.Add(cliente);

            // Salva o cliente
            booKidsContainer4.SaveChanges();

            // Mensagem de aviso
            MessageBox.Show("Cliente: " + tb_nome.Text + " adicinado com sucesso!");
            
            // Atualiza a base de dados
            lb_registar_clientes.DataSource = null;
            lb_registar_clientes.DataSource = booKidsContainer4.Pessoas.ToList<Pessoa>();
            }

        }

        // ------------- Função Ler dados da listbox Cliente ---------
        private void LerDados()
        {
            lb_registar_clientes.DataSource = booKidsContainer4.Pessoas.OfType<Cliente>().ToList<Pessoa>();

        }

        // ------------------- Apagar cliente ---------------------
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (lb_registar_clientes.SelectedIndex == 1)
                return;
            Pessoa pessoaSelecionada = (Pessoa)lb_registar_clientes.SelectedItem;
           
            // Remove um Cliente
            booKidsContainer4.Pessoas.Remove(pessoaSelecionada);

            // Salvar Alterações
            booKidsContainer4.SaveChanges();

            // Atualiza a base de dados
            lb_registar_clientes.DataSource = null;
            lb_registar_clientes.DataSource = booKidsContainer4.Pessoas.ToList<Pessoa>();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            booKidsContainer4 = new BooKidsContainer4();

            // Chama a função LerDados
            LerDados();
        }

        // ------------------ Selecionar linha para alterar dados -----------------------
        private void lb_registar_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_registar_clientes.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)lb_registar_clientes.SelectedItem;
            tb_nome.Text = clienteSelecionado.Nome;
            tb_morada.Text = clienteSelecionado.Morada;
            tb_localidade.Text = clienteSelecionado.Localidade;
            tb_codpostal.Text = clienteSelecionado.CodPostal;
            tb_telefone.Text = clienteSelecionado.Telefone;
            tb_telemovel.Text = clienteSelecionado.Telemovel;
            tb_mail.Text = clienteSelecionado.Mail;
            tb_Nrcartao.Text = clienteSelecionado.NrCartao;
            tb_Valoroferta.Text = clienteSelecionado.ValorOferta;

        }

        // -------------------- Alterar Cliente ---------------------------
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (lb_registar_clientes.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)lb_registar_clientes.SelectedItem;


            clienteSelecionado.Nome = tb_nome.Text;
            clienteSelecionado.Morada = tb_nome.Text;
            clienteSelecionado.Localidade = tb_localidade.Text;
            clienteSelecionado.CodPostal = tb_codpostal.Text;
            clienteSelecionado.Telefone = tb_telefone.Text;
            clienteSelecionado.Telemovel = tb_telemovel.Text;
            clienteSelecionado.Mail = tb_mail.Text;
            clienteSelecionado.NrCartao = tb_Nrcartao.Text;
            clienteSelecionado.ValorOferta = tb_Valoroferta.Text;

            // Atualiza a base de dados
            lb_registar_clientes.DataSource = null;
            lb_registar_clientes.DataSource = booKidsContainer4.Pessoas.ToList<Pessoa>();

            // Salva as alterações e mostra mensagem
            booKidsContainer4.SaveChanges();
            MessageBox.Show("Dados Alterados!");
        }

        // -------------- Função que só aceita números no telefone -----------------
        private void tb_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Introduza Números");
            }
        }

        // -------------- Função que só aceita números no telemovel -----------------
        private void tb_telemovel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Introduza Números");
            }
        }

        // -------------- Função que só aceita números no cartão  -----------------
        private void tb_Nrcartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Introduza Números");
            }
        }

        // -------------- Função que só aceita números no valor oferta  -----------------
        private void tb_Valoroferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Introduza Números");
            }
        }

        // ------------- Botão para limpar as textboxs --------------------
        private void buttonClean_Click(object sender, EventArgs e)
        {
            tb_codpostal.Text = "";
            tb_localidade.Text = "";
            tb_mail.Text = "";
            tb_morada.Text = "";
            tb_nome.Text = "";
            tb_Nrcartao.Text = "";
            tb_telefone.Text = "";
            tb_telemovel.Text = "";
            tb_Valoroferta.Text = "";
        }
    }
}

