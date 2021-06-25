using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Cliente
    {
        // ------------------ Construtor do Cliente ------------------------------
        public Cliente(string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string nrcartao, string valoroferta)
        {
            Nome = nome;
            Morada = morada;
            Localidade = localidade;
            CodPostal = codPostal;
            Telefone = telefone;
            Telemovel = telemovel;
            Mail = mail;
            NrCartao = nrcartao;
            ValorOferta = valoroferta;
        }

        // ----------- Função que mostra os dados na listbox -------------------
        public override string ToString()
        {
            return ("Nome: " + Nome + " Morada: " + Morada + " Localidade: " + Localidade + " CodPostal: " + CodPostal + " Telefone: " + Telefone + " Telemovel: " + Telemovel + " Email: " + Mail + " NrCartao " + NrCartao + " ValorOferta: " + ValorOferta);
        }
    }
}
