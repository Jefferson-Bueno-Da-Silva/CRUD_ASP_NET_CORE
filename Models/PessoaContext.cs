using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExemploWeb.Models
{
    public class PessoaContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public PessoaContext(DbContextOptions<PessoaContext> options): base(options)
        {

        }
    }
}
