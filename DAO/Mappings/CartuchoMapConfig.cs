using System.Data.Entity;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Mappings
{
    internal class CartuchoMapConfig : EntityTypeConfiguration<Cartucho>
    {
        public CartuchoMapConfig()
        {
            this.ToTable("CARTUCHOS");
            this.Property(c => c.NomeModelo).HasMaxLength(50).IsRequired().IsUnicode();
            this.Property(c => c.Cor).IsRequired().IsUnicode();
            this.Property(c => c.Quantidade).IsRequired();
            this.Property(c => c.ValorUnitario).IsRequired();
            this.Property(c => c.ValorTotalOrcamento).IsRequired();
        }
    }
}
