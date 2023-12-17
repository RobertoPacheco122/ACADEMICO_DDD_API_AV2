using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Turma : BaseEntity {
        public ETurno Turno { get; set; }

        public int IdDisciplina { get; set; }
        public Disciplina? Disciplina { get; set; }
        public int IdProfessor { get; set; }
        public Professor? Professor { get; set; }
        public List<Aluno>? Alunos { get; set; }
    }
}
