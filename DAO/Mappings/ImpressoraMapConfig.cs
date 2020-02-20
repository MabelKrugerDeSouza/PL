using Entity;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Mappings
{
    internal class ImpressoraMapConfig : EntityTypeConfiguration<Impressora>
    {
        public ImpressoraMapConfig()
        {
            this.ToTable("IMPRESSORAS");
            this.Property(c => c.Modelo).HasMaxLength(50).IsRequired().IsUnicode();
            this.Property(c => c.ValorTotal).IsRequired();
            this.Property(c => c.ValorTotalLocacao).IsRequired();
        }
        
    }
}
