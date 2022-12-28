using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlunoCrud.Models;

namespace AlunoCrud.Data
{
    public class AlunoCrudContext : DbContext
    {
        public AlunoCrudContext (DbContextOptions<AlunoCrudContext> options)
            : base(options)
        {
        }

        public DbSet<AlunoCrud.Models.Aluno> Aluno { get; set; }
    }
}
