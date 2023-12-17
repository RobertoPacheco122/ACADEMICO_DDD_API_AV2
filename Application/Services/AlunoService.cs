using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Aluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class AlunoService : IAlunoService {
        private readonly IRepository<Aluno> _repository;

        public AlunoService(IRepository<Aluno> repository) {
            _repository = repository;
        }

        public async Task<bool> Delete(int id) {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Aluno>> GetAll() {
            return await _repository.GetAllAsync();
        }

        public async Task<Aluno> GetSingle(int id) {
            return await _repository.SelectAsync(id);
        }

        public async Task<Aluno> Insert(Aluno aluno) {
            return await _repository.InsertAsync(aluno);
        }

        public async Task<Aluno> Update(Aluno aluno) {
            return await _repository.UpdateAsync(aluno);
        }
    }
}
