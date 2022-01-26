
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UsuarioPermissao.Models;

namespace UsuarioPermissao.API.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Usuarios> Usuarios { get; set; }

        // public DbSet<Professor> Professores { get; set; }
        // public DbSet<Disciplina> Disciplinas { get; set; }
        // public DbSet<AlunoDisciplina> AlunoDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

         

        }

    }
}