using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Escola
    {

        // ------------------ Construtor do Animador ------------------------------
        public Escola(string nome, string morada, string telefone, string mail, string codPostal, string localidade)
        {
            Nome = nome;
            Morada = morada;
            Telefone = telefone;
            Mail = mail;
            CodPostal = codPostal;
            Localidade = localidade;
        }

        // ----------- Função que mostra os dados na listbox -------------------
        public override string ToString()
        {
            return "Escola: " + Nome + " Situada em : " + Localidade + " . Contacte em : " + Telefone + " / " + Mail;
        }
    }
}
