using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Movimentacao
    {
        public int ID { get; set; }
        public int ImpressoraID { get; set; }
        public virtual Impressora Impressora { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public double ValorTotalOrcamento { get; set; }

    }
}
