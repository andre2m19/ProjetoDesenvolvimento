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
    
    public partial class Filho : Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filho()
        {
            this.Inscricoes = new HashSet<Inscricao>();
        }
    
        public int Sexo { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string IdEscola { get; set; }
        public string IdProgenitor { get; set; }
    
        public virtual Cliente Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscricao> Inscricoes { get; set; }
        public virtual Escola Escolas { get; set; }
    }
}
