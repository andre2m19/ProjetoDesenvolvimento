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
using System.IO;

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

            // Declarar variáveis
            string Designacao = tb_designacao.Text;
            short Preco = short.Parse(tb_Preco.Text);
            int CodTipoProduto = int.Parse(tb_CTP.Text);
            string StockExistente = tb_Stock_Existente.Text;


            // Instanciar o Produto
            Produto produtos = new Produto(Designacao, Preco, CodTipoProduto, StockExistente);
            
            // Adiciona um Produto
            booKidsContainer4.Produtoes.Add(produtos);

            // Salvar Produto
            booKidsContainer4.SaveChanges();
            // Atualiza a base de dados
            lb_produtos.DataSource = null;
            lb_produtos.DataSource = booKidsContainer4.Produtoes.ToList<Produto>();        

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

        // ------------------- Recibo de Venda -----------------------------
        private void formatoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_produtos.SelectedIndex == -1)
                return;
            //criação do ficheiro txt
            saveFileDialogTexto.FileName = "Recibo de Venda" + ".txt";
            if (saveFileDialogTexto.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StreamWriter ficheiro = new StreamWriter(saveFileDialogTexto.FileName, false);


            foreach (Produto c in booKidsContainer4.Produtoes)
            {
                ficheiro.WriteLine("\t\t\t\t Recibo de Venda - Produto");
                ficheiro.WriteLine("\nDesignação: ________________________________ " + c.Designacao);
                ficheiro.WriteLine("\nPreço: _____€" + c.Preco);
                ficheiro.WriteLine("\nStock Existente: __________" + c.StockExistente);
                foreach (Produto b in booKidsContainer4.Produtoes)
                {
                    ficheiro.WriteLine(b.ToString());
                }

            }
            ficheiro.Close();
            MessageBox.Show("O ficheiro foi guardado com o nome: " + saveFileDialogTexto.FileName);
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            booKidsContainer4 = new BooKidsContainer4();

            // Chama a função LerDados
            LerDados();
        }


        // -------------------- Função LerDados ----------------------------
        private void LerDados()
        {
            lb_produtos.DataSource = booKidsContainer4.Produtoes.OfType<Produto>().ToList<Produto>();

        }
        // --------- Alterar o animador na base de dados --------------
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (lb_produtos.SelectedIndex == -1)
                return;

            Produto produtoSelecionado = (Produto)lb_produtos.SelectedItem;


            produtoSelecionado.Designacao = tb_designacao.Text;
            produtoSelecionado.Preco = int.Parse(tb_Preco.Text);
            produtoSelecionado.CodTipoProduto = int.Parse(tb_CTP.Text);
            produtoSelecionado.StockExistente = tb_Stock_Existente.Text;


            // Guarda as alterações
            booKidsContainer4.SaveChanges();
            MessageBox.Show("Dados Alterados!");

            // Atualiza a base de dados
            lb_produtos.DataSource = null;
            lb_produtos.DataSource = booKidsContainer4.Produtoes.ToList<Produto>();

        }
    }
}
