using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {
        }
        public DbSet<Contato> Contato { get; set; }
   

    }
}
