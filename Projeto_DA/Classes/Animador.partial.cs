using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Animador
    {
        // ------------------ Construtor do Animador ------------------------------
        public Animador(int idPessoa, string nome, string morada, string localidade, string codpostal, string telefone, string telemovel, string mail, string especialidade)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            Morada = morada;
            Localidade = localidade;
            CodPostal = codpostal;
            Telefone = telefone;
            Telemovel = telemovel;
            Mail = mail;
            Especialidade = especialidade;
        }

        // ----------- Função que mostra os dados na listbox -------------------
        public override string ToString()
        {
            return "Sr/Sra " + Nome + " reside em " + Morada + ". Contacte em " + Mail;
        }
    }
}
