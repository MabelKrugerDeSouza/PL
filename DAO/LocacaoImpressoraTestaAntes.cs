using Entity;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class LocacaoImpressoraTestaAntes : DropCreateDatabaseAlways<LocacaoImpressoraDbContext>
    {
        protected override void Seed(LocacaoImpressoraDbContext context)
        {
            using (context)
            {
                Cliente c = new Cliente()
                {
                    Name = "Carlos H Oliveira",
                    Ativo = true,
                    CPF = "093.095.979-77",
                    DataNascimento = DateTime.Now.AddYears(-19),
                    Email = "Caik_oliveiiiirarapires@hotmail.com"
                };
                context.Clientes.Add(c);
                context.SaveChanges();


            }
            base.Seed(context);
        }


    }
    
}
