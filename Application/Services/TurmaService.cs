using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Turma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class TurmaService : ITurmaService {
        private readonly IRepository<Turma> _repository;
        public TurmaService(IRepository<Turma> repository) {
            _repository = repository;
        }

        public async Task<bool> Delete(int id) {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Turma>> GetAll() {
            return await _repository.GetAllAsync();
        }

        public async Task<Turma> GetSingle(int id) {
            return await _repository.SelectAsync(id);
        }

        public async Task<Turma> Insert(Turma turma) {
            return await _repository.InsertAsync(turma);
        }

        public async Task<Turma> Update(Turma turma) {
            return await _repository.UpdateAsync(turma);
        }
    }
}
