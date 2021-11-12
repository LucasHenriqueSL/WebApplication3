using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Context: DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            //optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocal; Database =Cursomvc;Integrated Security=True");
            optionsBuilder.UseSqlServer(connectionString: @"Server=.\SQLEXPRESS; Database =Cursomvc;Integrated Security=True");
        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
