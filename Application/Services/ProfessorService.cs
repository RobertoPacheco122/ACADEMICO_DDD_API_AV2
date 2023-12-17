using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Professor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class ProfessorService : IProfessorService {
        private readonly IRepository<Professor> _repository;

        public ProfessorService(IRepository<Professor> repository) {
            _repository = repository;
        }

        public async Task<bool> Delete(int id) {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Professor>> GetAll() {
            return await _repository.GetAllAsync();
        }

        public async Task<Professor> GetSingle(int id) {
            return await _repository.SelectAsync(id);
        }

        public async Task<Professor> Insert(Professor professor) {
            return await _repository.InsertAsync(professor);
        }

        public async Task<Professor> Update(Professor professor) {
            return await _repository.UpdateAsync(professor);
        }
    }
}
