using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.Base_de_dados;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Produtos : Form
    {
       private BooKidsContainer4 booKidsContainer4;
        public Produtos()
        {
            InitializeComponent();
            booKidsContainer4 = new BooKidsContainer4();
            lb_produtos.DataSource = booKidsContainer4.Pessoas.OfType<Cliente>().ToList<Cliente>();
        }


        // ------------------ Inserir Produto ---------------------------
        private void btn_Registar_Click(object sender, EventArgs e)
        {
            string Designacao = tb_designacao.Text;
            short Preco = short.Parse(tb_Preco.Text);
            int CodTipoProduto = int.Parse(tb_CTP.Text);
            string StockExistente = tb_Stock_Existente.Text;


            Produto produtos = new Produto(Designacao, Preco, CodTipoProduto, StockExistente);
            booKidsContainer4.Produtoes.Add(produtos);
            lb_produtos.DataSource = null;
            lb_produtos.DataSource = booKidsContainer4.Produtoes.ToList<Produto>();



            booKidsContainer4.SaveChanges();
            //if(Preco != short && CodTipoProduto && int)
            {

            }
        }

        // ------------------- Apgar Produto --------------------------
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (lb_produtos.SelectedIndex == 1)
                return;
            Produto produtoSelecionado = (Produto)lb_produtos.SelectedItem;
            booKidsContainer4.Produtoes.Remove(produtoSelecionado);
            booKidsContainer4.SaveChanges();
            lb_produtos.DataSource = null;
            lb_produtos.DataSource = booKidsContainer4.Produtoes.ToList<Produto>();
            
            MessageBox.Show("Cliente apagado com sucesso!");
        }
    }
    }
