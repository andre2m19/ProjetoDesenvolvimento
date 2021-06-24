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


    public partial class Compras : Form
    {
        public BooKidsContainer4 booKidsContainer4;
        public Compras()
        {
            InitializeComponent();
            booKidsContainer4 = new BooKidsContainer4();

        }   
        private void LerDados()
        {
            lb_registar_produtos_vendidos.DataSource = booKidsContainer4.Compras.ToList<Compra>(); 

        }
        // ------------------- Registar Compra ----------------------------
        private void btn_Registar_Click_1(object sender, EventArgs e)
        {
            DateTime Data = tp_data.Value;
            int IdCliente = int.Parse(tb_id.Text);
            int ProdutosCodProduto = int.Parse(tb_produtosCodProduto.Text);
            string UtilizouCartao = tb_utilizouCartao.Text;
            int clientesIdPessoa = int.Parse(tb_clientesIdPessoa.Text);
           


            Compra compra = new Compra(Data, UtilizouCartao, ProdutosCodProduto, clientesIdPessoa, IdCliente);
      

            lb_registar_produtos_vendidos.DataSource = null;
            lb_registar_produtos_vendidos.DataSource = booKidsContainer4.Compras.ToList <Compra>();
            booKidsContainer4.Compras.Add(compra);
           

            booKidsContainer4.SaveChanges();
        }

      
        // -------------------------- Apagar Compra -----------------------------------
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (lb_registar_produtos_vendidos.SelectedIndex == 1)
                return;
            Compra compraSelecionada = (Compra)lb_registar_produtos_vendidos.SelectedItem;
            booKidsContainer4.Compras.Remove(compraSelecionada);
            booKidsContainer4.SaveChanges();
            lb_registar_produtos_vendidos.DataSource = null;
            lb_registar_produtos_vendidos.DataSource = booKidsContainer4.Compras.ToList<Compra>();
            

            MessageBox.Show("Cliente apagado com sucesso!");
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            booKidsContainer4 = new BooKidsContainer4();

            listBoxClientes.DataSource = booKidsContainer4.Pessoas.ToList<Pessoa>();

            LerDados();

            tb_clientesIdPessoa.ReadOnly = true;
            tb_id.ReadOnly = true;
        }
        private void lb_registar_produtos_vendidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_registar_produtos_vendidos.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)lb_registar_produtos_vendidos.SelectedItem;
            
            /*tb_Valoroferta.Text = clienteSelecionado.ValorOferta;
            tp_data.Value = compraSelecionada.Data;
            compraSelecionada.IdCliente = int.Parse(tb_id.Text);
            compraSelecionada.ProdutosCodProduto = int.Parse(tb_produtosCodProduto.Text);
            compraSelecionada.UtilizouCartao = tb_utilizouCartao.Text;
            compraSelecionada.ClientesIdPessoa = int.Parse(tb_clientesIdPessoa.Text);*/

        }


        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (lb_registar_produtos_vendidos.SelectedIndex == -1)
                return;

            Compra compraSelecionada = (Compra)lb_registar_produtos_vendidos.SelectedItem;


            compraSelecionada.Data = tp_data.Value;
            compraSelecionada.IdCliente = int.Parse(tb_id.Text);
            compraSelecionada.ProdutosCodProduto = int.Parse(tb_produtosCodProduto.Text);
            compraSelecionada.UtilizouCartao = tb_utilizouCartao.Text;
            //compraSelecionada.ClientesIdPessoa = int.Parse(tb_clientesIdPessoa.Text);

            lb_registar_produtos_vendidos.DataSource = null;
            lb_registar_produtos_vendidos.DataSource = booKidsContainer4.Compras.ToList<Compra>();


            booKidsContainer4.SaveChanges();
            MessageBox.Show("Dados Alterados!");
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa pessoaSelecionada = (Pessoa)listBoxClientes.SelectedItem;

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            string idPessoa = pessoaSelecionada.IdPessoa.ToString();
            string idCliente = clienteSelecionado.IdPessoa.ToString();

            tb_id.Text = idPessoa;
            tb_clientesIdPessoa.Text = idCliente;
           
        }
    }
 }
