using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cartucho
    {
        public int ID { get; set; }
        public string NomeModelo { get; set; }
        public string Cor { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotalOrcamento { get; set; }
    }
}
