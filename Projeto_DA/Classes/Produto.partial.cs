using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Produto
    {
        public Produto(string designacao, short preco, int codTipoProduto, string stockExistente)
        {
            Designacao = designacao;
            Preco = preco;
            CodTipoProduto = codTipoProduto;
            StockExistente = stockExistente;
        }
    }
}
