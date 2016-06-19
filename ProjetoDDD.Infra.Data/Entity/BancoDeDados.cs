using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Entity
{
    public class BancoDeDados : DbContext
    {

        public BancoDeDados() : base("ProjetoDDD_DataBase")
        {
                
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

    }
}
