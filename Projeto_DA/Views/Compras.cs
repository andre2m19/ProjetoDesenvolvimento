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

        private void Vendas_Load(object sender, EventArgs e)
        {
            booKidsContainer4 = new BooKidsContainer4();
            LerDados();
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
            int ClientesIdPessoa = int.Parse(tb_clientesIdPessoa.Text);
            //int Quantidade = int.Parse(tb_quantidade.Text);


            Compra compra = new Compra(Data, UtilizouCartao, IdCliente, ProdutosCodProduto, ClientesIdPessoa); //Quantidade);


            lb_registar_produtos_vendidos.DataSource = null;
            lb_registar_produtos_vendidos.DataSource = booKidsContainer4.Compras.ToList <Compra>();
            booKidsContainer4.Compras.Add(compra);


            booKidsContainer4.SaveChanges();
        }

        private void Compras_Load_1(object sender, EventArgs e)
        {
            booKidsContainer4 = new BooKidsContainer4();
            LerDados();
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
            Cursor = Cursors.Hand;

            MessageBox.Show("Cliente apagado com sucesso!");
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }
    }
}
