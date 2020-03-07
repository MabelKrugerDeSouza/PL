using DAO.Mappings;
using Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LocacaoImpressoraDbContext : DbContext
    {
        public LocacaoImpressoraDbContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new LocacaoImpressoraTestaAntes());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Impressora> Impressoras { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations
                        .AddFromAssembly(Assembly.GetExecutingAssembly());


            //Adição de uma configuração global que sobrescreve
            //a convenção padrão da string e a faz já ser VARCHAR NOT NULL
            modelBuilder.Properties()
                        .Where(c => c.PropertyType == typeof(string))
                        .Configure(c => c.IsRequired().IsUnicode(false));

            //Configuração global que determina que toda
            //propriedade DateTime deve será mapeada para 
            //datetime2.
            //Lembrando que é possível sobrescrever este comportamento
            //utilizando configurações locais na classes EntityTypeConfiguration<T>
            modelBuilder.Properties()
            .Where(c => c.PropertyType == typeof(DateTime))
            .Configure(c => c.HasColumnType("datetime2"));

            //Irá comparar as suas entidades (que estão encapsuladas nos DbSet<T> acima)
            //com a estrutura do banco. Se a base não existir, o EF irá criar. Se a base existir,
            //mas estiver diferente (o banco com uma ou mais diferença(s) de coluna(s)), o EF
            //ira executar uma política de DROP.
            base.OnModelCreating(modelBuilder);
        }
















    }
   
}
