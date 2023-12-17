using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Professor {
    public interface IProfessorService {
        Task<bool> Delete(int id);
        Task<List<Entities.Professor>> GetAll();
        Task<Entities.Professor> GetSingle(int id);
        Task<Entities.Professor> Insert(Entities.Professor professor);
        Task<Entities.Professor> Update(Entities.Professor professor);
    }
}
