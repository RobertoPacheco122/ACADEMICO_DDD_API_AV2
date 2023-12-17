using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aluno> Alunos => Set<Aluno>();
        public DbSet<Disciplina> Disciplinas => Set<Disciplina>();
        public DbSet<Professor> Professores => Set<Professor>();
        public DbSet<Turma> Turmas => Set<Turma>();
    }
}

