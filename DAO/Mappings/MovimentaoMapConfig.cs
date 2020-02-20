using Entity;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DAO.Mappings
{
    internal class MovimentaoMapConfig : EntityTypeConfiguration<Movimentacao>
    {
        public MovimentaoMapConfig()
        {
            this.ToTable("MOVIMENTACOES");
            this.Property(c => c.ImpressoraID).IsRequired();
            this.HasRequired(c => c.Impressora).WithMany(c => c.Movimentacoes).WillCascadeOnDelete(false);
            this.Property(c => c.DataLocacao).HasColumnType("date").IsRequired();
            this.Property(c => c.DataDevolucao).HasColumnType("date").IsRequired();
            this.Property(c => c.ValorTotalOrcamento).HasColumnType("orcamento").IsRequired();
            

        }
    }
}

