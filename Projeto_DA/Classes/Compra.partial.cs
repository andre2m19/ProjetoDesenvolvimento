using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{

    public partial class Compra
    {

       // ------------------ Construtor da Compra ------------------------------
        public Compra(DateTime data, string utilizouCartao, int idCliente, int produtosCodProduto, int clientesIdPessoa)
        {
            Data = data;
            UtilizouCartao = utilizouCartao;
            IdCliente = idCliente;
            ProdutosCodProduto = produtosCodProduto;
           
        }
      
        // ----------- Função que mostra os dados na listbox -------------------
       public override string ToString()
        {
            return ("Data: " + Data + " UtilizouCartao: " + UtilizouCartao + " IdCliente: " + IdCliente + " ProdutosCodProduto: " + ProdutosCodProduto);
        }

    }
}
