using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projeto_DA.Base_de_dados
{
    public partial class Evento
    {
        // ------------------ Construtor do Evento ------------------------------
        public Evento(string descricao, string local, DateTime dataHora, string limiteParticipacoes, int idadeSuperior, int idadeInferior, string tipoEvento)
        {
            Descricao = descricao;
            Local = local;
            DataHora = dataHora;
            IdadeSuperior = idadeSuperior;
            IdadeInferior = idadeInferior;
            LimitePartcipacoes = limiteParticipacoes;
            TipoEvento = tipoEvento;
          

        }

        // ----------- Função que mostra os dados na listbox -------------------
        public override string ToString()
        {
            return ("Descicao--->" + Descricao + "Local--->" + Local + "Data Hora--->" + DataHora + "Idade Superior--->" + IdadeSuperior + "Idade Inferior--->" + IdadeInferior + "Limite Participacoes--->" + LimitePartcipacoes + "Tipo Evento--->" + TipoEvento);
        }
    }
}