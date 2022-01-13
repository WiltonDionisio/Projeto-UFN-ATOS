using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto3.Models;

namespace Projeto3.Data
{
    public class Projeto3Context : DbContext
    {
        public Projeto3Context (DbContextOptions<Projeto3Context> options)
            : base(options)
        {
        }

        public DbSet<Locadora> Locadora { get; set; }
        public DbSet<Automoveis> Automovel{ get; set; }
        public DbSet<VeiculoAlugado> VeiculoAlugados { get; set; }
    }
}
