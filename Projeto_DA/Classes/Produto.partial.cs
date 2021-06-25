using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Produto
    {
        // ------------------ Construtor do Animador -----------------------------~-
        public Produto(string designacao, short preco, int codTipoProduto, string stockExistente)
        {
            Designacao = designacao;
            Preco = preco;
            CodTipoProduto = codTipoProduto;
            StockExistente = stockExistente;
        }

        // ----------- Função que mostra os dados na listbox -------------------
        public override string ToString()
        {
            return ("Designação: " + Designacao + " Preço: " + Preco + " CodTipoProduto: " +CodTipoProduto+ " StockExistente: " + StockExistente);
        }
    }
}
