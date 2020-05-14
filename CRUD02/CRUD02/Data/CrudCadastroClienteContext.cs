using CrudCadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudCadastroCliente.Data
{
    public class CrudCadastroClienteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CrudCadastroClienteContext() : base("CrudCadastroClienteDb")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Consultor> Consultors { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
    }
}
