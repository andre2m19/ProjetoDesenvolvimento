using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Escola
    {
        public Escola(string nome, string morada, string telefone, string mail, string codPostal, string localidade)
        {
            Nome = nome;
            Morada = morada;
            Telefone = telefone;
            Mail = mail;
            CodPostal = codPostal;
            Localidade = localidade;
        }

        public override string ToString()
        {
            return "Escola: " + Nome + " Situada em : " + Localidade + " . Contacte em : " + Telefone + " / " + Mail;
        }
    }
}
