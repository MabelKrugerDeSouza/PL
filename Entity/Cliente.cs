using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}
