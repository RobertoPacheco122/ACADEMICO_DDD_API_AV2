using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Disciplina : BaseEntity {
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;
        public int Periodo { get; set; }
        public int CreditoNecessario { get; set; }

        public List<Turma>? Turmas { get; set; }
    }
}
