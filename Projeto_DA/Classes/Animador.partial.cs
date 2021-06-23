using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Animador
    {
        public Animador(int idPessoa, string nome, string morada, string localidade, string codpostal, int telefone1, int telefone2, string mail, string especialidade)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            Morada = morada;
            Localidade = localidade;
            CodPostal = codpostal;
            Mail = mail;
            Especialidade = especialidade;
        }

        public override string ToString()
        {
            return "Sr/Sra" + Nome + " reside em " + Morada + ". Contacte em " + Mail;
        }
    }
}
