
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using project_school_api.Models;

namespace project_school_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Professor>().HasData
            (
                new List<Professor>(){
                  new Professor(){
                      Id = 1,
                      Nome = "Vinicius"
                  },
                   new Professor(){
                      Id = 2,
                      Nome = "Paula"
                  },
                  new Professor(){
                      Id = 3,
                      Nome = "  Luna"
                  }
                }
            );

            builder.Entity<Aluno>().HasData
           (
               new List<Aluno>(){
                  new Aluno(){
                      Id = 1,
                      Nome = "Maria",
                      Sobrenome = "José",
                      DataNasc = "10/11/1998",
                      ProfessorId = 1
                    },
                   new Aluno(){
                      Id = 2,
                      Nome = "João",
                      Sobrenome = "Pedro",
                      DataNasc = "3/11/1992",
                      ProfessorId = 2
                    },
                  new Aluno(){
                      Id = 3,
                      Nome = "Alex",
                      Sobrenome = "Camões",
                      DataNasc = "13/09/2003",
                      ProfessorId = 3
                    }
               }
           );
        }
    }
}