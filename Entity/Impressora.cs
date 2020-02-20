using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Impressora
    {
        public int ID { get; set; }
        public string Modelo { get; set; }
        public double ValorTotal { get; set; }
        public double ValorTotalLocacao { get; set; }
        public bool ImpressorasDisponiveis { get; set; }
        public virtual ICollection<Movimentacao> Movimentacoes { get; set; }

    }
}
