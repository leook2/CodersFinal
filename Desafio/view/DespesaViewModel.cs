using System;
using System.ComponentModel.DataAnnotations;

namespace Desafio.view
{
    public class DespesaViewModel
    {
        [Required]
        public int unidade { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public string tipoDespesa { get; set; }
        [Required]
        public float valor { get; set; }
        [Required]
        public DateTime vencimentoFatura { get; set; }
        [Required]
        public string statusPagamento { get; set; }
    }
}
