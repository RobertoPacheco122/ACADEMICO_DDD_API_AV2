using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Aluno : BaseEntity {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public DateOnly DataNascimento { get; set; }

        public List<Turma>? Turmas { get; set; }
    }
}
