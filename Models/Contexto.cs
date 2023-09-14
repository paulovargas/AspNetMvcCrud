using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; } = null!;

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }        
    }
}