using DesafioPjus.Domain.Cep;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioPjus.Infrastructure.Data
{
    public class DesafioPjusDbContext : DbContext
    {
        public DesafioPjusDbContext(DbContextOptions<DesafioPjusDbContext> options) : base(options) { }

        public DbSet<Cep> Cep { get; set; }

    }
}
