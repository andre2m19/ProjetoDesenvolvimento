﻿using Projeto_DA.Base_de_dados;
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

        }
        BooKidsContainer4 bk = new BooKidsContainer4();
   

        // ----------------- Criar cliente -----------------------
        private void btn_Registar_Click(object sender, EventArgs e)
        {
            string Nome = tb_nome.Text;
            string Morada = tb_morada.Text;
            string Localidade = tb_localidade.Text;
            string CodPostal = tb_codpostal.Text;
            int Telefone = int.Parse(tb_telefone.Text);
            int Telemovel = int.Parse(tb_telemovel.Text);
            string Mail = tb_mail.Text;
            int Nr_cartao = int.Parse(tb_Nrcartao.Text);
            int Valor_oferta = int.Parse(tb_Valoroferta.Text);


            Cliente cliente = new Cliente(Nome, Morada, Localidade, CodPostal, Telefone, Telemovel, Mail, Nr_cartao, Valor_oferta);
            booKidsContainer4.Pessoas.Add(cliente);

            booKidsContainer4.SaveChanges();

            MessageBox.Show("Cliente: " + tb_nome.Text + " adicinado com sucesso!");
        
        }
        private void LerDados()
        {
            lb_registar_clientes.DataSource = booKidsContainer4.Pessoas.ToList<Pessoa>(); ;

        }

        // ------------------- Apagar cliente ---------------------
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (lb_registar_clientes.SelectedIndex == 1)
                return;
            Pessoa pessoaSelecionada = (Pessoa)lb_registar_clientes.SelectedItem;
            booKidsContainer4.Pessoas.Remove(pessoaSelecionada);
            booKidsContainer4.SaveChanges();
            lb_registar_clientes.DataSource = null;
            lb_registar_clientes.DataSource = booKidsContainer4.Pessoas.ToList<Pessoa>();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            booKidsContainer4 = new BooKidsContainer4();
            LerDados();
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
            clienteSelecionado.Telefone = int.Parse(tb_telefone.Text);
            clienteSelecionado.Telemovel = int.Parse(tb_telemovel.Text);
            clienteSelecionado.Mail = tb_mail.Text;
            clienteSelecionado.NrCartao = int.Parse(tb_Nrcartao.Text);
            clienteSelecionado.ValorOferta = int.Parse(tb_Valoroferta.Text);

            lb_registar_clientes.DataSource = null;
            lb_registar_clientes.DataSource = booKidsContainer4.Pessoas.ToList<Pessoa>();
           
        

            booKidsContainer4.SaveChanges();
            MessageBox.Show("Dados Alterados!");
        }

        // ------------------ Slecionar linha para alterar dados -----------------------
        private void lb_registar_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_registar_clientes.SelectedIndex == -1)
                return;
            
            Cliente clienteSelecionado = (Cliente)lb_registar_clientes.SelectedItem;
            tb_nome.Text = clienteSelecionado.Nome;
            tb_morada.Text = clienteSelecionado.Morada;
            tb_localidade.Text = clienteSelecionado.Localidade;
            //tb_telefone.Text= clienteSelecionado.Telefone;
            //tb_telemovel.Text = clienteSelecionado.Telemovel;
            tb_mail.Text = clienteSelecionado.Mail;
           // tb_Nrcartao.Text = clienteSelecionado.NrCartao;
           // tb_Valoroferta.Text = clienteSelecionado.ValorOferta;
            

     
           


        }
    }
}
