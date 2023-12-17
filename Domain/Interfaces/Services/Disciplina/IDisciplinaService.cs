using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Disciplina {
    public interface IDisciplinaService {
        Task<bool> Delete(int id);
        Task<List<Entities.Disciplina>> GetAll();
        Task<Entities.Disciplina> GetSingle(int id);
        Task<Entities.Disciplina> Insert(Entities.Disciplina disciplina);
        Task<Entities.Disciplina> Update(Entities.Disciplina disciplina);
    }
}
