//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_DA.Base_de_dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalheCompra
    {
        public string Quantidade { get; set; }
        public int ComprasNrCompra { get; set; }
        public int ProdutosCodProduto { get; set; }
    
        public virtual Produto Produtos { get; set; }
        public virtual Compra Compras { get; set; }
    }
}
