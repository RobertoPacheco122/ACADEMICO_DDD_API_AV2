using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Aluno {
    public interface IAlunoService {
        Task<bool> Delete(int id);
        Task<List<Entities.Aluno>> GetAll();
        Task<Entities.Aluno> GetSingle(int id);
        Task<Entities.Aluno> Insert(Entities.Aluno aluno);
        Task<Entities.Aluno> Update(Entities.Aluno aluno);
    }
}
