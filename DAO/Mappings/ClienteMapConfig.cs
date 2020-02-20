using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Mappings
{
    internal class ClienteMapConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapConfig()
        {
            //FLUENT API
            this.ToTable("CLIENTES");

            this.Property(c => c.Name).HasMaxLength(50).IsRequired();
            this.Property(c => c.CPF).IsFixedLength().HasMaxLength(14);
            this.Property(c => c.DataNascimento).HasColumnType("date").IsRequired();
            this.Property(c => c.Email).HasMaxLength(65).IsUnicode();


        }

    }
}
