using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Turma {
    public interface ITurmaService {
        Task<bool> Delete(int id);
        Task<List<Entities.Turma>> GetAll();
        Task<Entities.Turma> GetSingle(int id);
        Task<Entities.Turma> Insert(Entities.Turma turma);
        Task<Entities.Turma> Update(Entities.Turma turma);
    }
}
