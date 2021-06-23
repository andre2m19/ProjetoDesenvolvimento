using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Base_de_dados
{
    public partial class Evento
    {
        public Evento(string descricao, string local, DateTime dataHora, string limiteParticipacoes, int idadeSuperior, int idadeInferior, string tipoEvento)
        {
            Descricao = descricao;
            Local = local;
            DataHora = dataHora;
            IdadeSuperior = idadeSuperior;
            IdadeInferior = idadeInferior;
            TipoEvento = tipoEvento;
        }
    }
}
