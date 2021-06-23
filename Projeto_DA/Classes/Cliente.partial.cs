using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Cliente
    {
        public Cliente(string nome, string morada, string localidade, string codPostal, int telefone, int telemovel, string mail, int nr_cartao, int valor_oferta)
        {
            Nome = nome;
            Morada = morada;
            Localidade = localidade;
            CodPostal = codPostal;
            Telefone = telefone;
            Telemovel = telemovel;
            Mail = mail;
        }
    }
}
