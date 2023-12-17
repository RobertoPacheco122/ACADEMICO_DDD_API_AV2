using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class DisciplinaService : IDisciplinaService {
        private readonly IRepository<Disciplina> _repository;
        public DisciplinaService(IRepository<Disciplina> repository) {
            _repository = repository;
        }

        public async Task<bool> Delete(int id) {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Disciplina>> GetAll() {
            return await _repository.GetAllAsync();
        }

        public async Task<Disciplina> GetSingle(int id) {
            return await _repository.SelectAsync(id);
        }

        public async Task<Disciplina> Insert(Disciplina disciplina) {
            return await _repository.InsertAsync(disciplina);
        }

        public async Task<Disciplina> Update(Disciplina disciplina) {
            return await _repository.UpdateAsync(disciplina);
        }
    }
}
