using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Model
{
    public class Despesa
    {
        public int idDespesa { get; set; }
        public int unidade { get; set; }
        public string descricao { get; set; }
        public string tipoDespesa { get; set; }
        public float valor { get; set; }
        public DateTime vencimentoFatura { get; set; }
        public string statusPagamento { get; set; }
    }
}
