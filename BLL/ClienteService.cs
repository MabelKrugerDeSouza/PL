using BLL.Interfaces;
using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService
    {
        public void Insert(Cliente cliente)
        {
            //Validar
            using (LocacaoImpressoraDbContext db = new LocacaoImpressoraDbContext())
            {

                //Ao buscar um dado do entity, existe um mecanismo conhecido 
                //como TRACKING. Este mecanismo observa as alterações feitas 
                //no objeto e, quando o método SaveChanges é chamado na base,
                //ele efetuará um update de tudo que foi alterado.
                Cliente c = db.Clientes.Find(8);
                c.Name += "Carlos";
                db.SaveChanges();

                //Update sem a necessidade de ir no banco a primeira vez pra buscar pelo id
                Impressora ImpressoraASerAtualizada = new Impressora();
                ImpressoraASerAtualizada.ID = 5;
                ImpressoraASerAtualizada.Modelo = "SAMSUNG M4070FR M4070 SL-M4070FR MONOCROMÁTICA MULTIFUNCIONAL PRO XPRESS";
                ImpressoraASerAtualizada.ValorTotal = 3.000;
                ImpressoraASerAtualizada.ValorTotalLocacao = 250;
                db.Entry<Impressora>(ImpressoraASerAtualizada).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //Delete
                Impressora ImpressoraASerExcluida = new Impressora();
                ImpressoraASerAtualizada.ID = 3;
                db.Entry<Impressora>(ImpressoraASerAtualizada).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();





                //Exemplo de pesquisa de clientes que contenham a letra 'a' no nome, ordenados
                //por nome decrescentemente e; caso os nomes sejam iguais, ordena por id.
                List<Cliente> clientes = db.Clientes.Where(cli => cli.Name.Contains("a"))
                                           .OrderByDescending(cli => cli.Name)
                                           .ThenBy(cli => cli.ID)
                                           .ToList();

                //Retorna o valor total já pago pelo cliente em todas as movimentações do primeiro
                //cliente que tenha a letra "a" no nome
                //double valor = clientes.First().Movimentacoes.Sum(soma => soma.ValorTotal);
                double valor = clientes[0].Movimentacoes.Sum(soma => soma.ValorTotalOrcamento);

                
                Impressora PesquisaNome = db.Impressoras.Find("S");
                
                Impressora PesquisaID = db.Impressoras.Find(6);

                List<Impressora> impressoras = db.Impressoras.Where(Im => Im.ImpressorasDisponiveis).ToList();

                Movimentacao Mov = new Movimentacao();
                List<Movimentacao> movimentacoes = db.Movimentacoes.Where(m => m.DataLocacao.Date == DateTime.Now.Date).ToList();
                


                Cliente Cl = new Cliente()
                {
                    Name = "Danizinho Bernart",
                    Ativo = true,
                    CPF = "901.917.069-49",
                    DataNascimento = DateTime.Now.AddYears(-25)
                };
                Impressora I = new Impressora()
                {
                   
                };
                db.Clientes.Add(Cl);
                db.Impressoras.Add(I);
                db.SaveChanges();
            }
        }
    }
}
