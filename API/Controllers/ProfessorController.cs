using Domain.Entities;
using Domain.Interfaces.Services.Professor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase {
        private readonly IProfessorService _service;
        public ProfessorController(IProfessorService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Professor>>> GetAll() {
            try {
                var response = await _service.GetAll();

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Professor>> GetSingle(int id) {
            try {
                var response = await _service.GetSingle(id);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Professor>> Insert([FromBody] Professor professor) {
            try {
                var response = await _service.Insert(professor);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult<Professor>> Update([FromBody] Professor professor) {
            try {
                var response = await _service.Update(professor);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Professor>> Delete(int id) {
            try {
                var response = await _service.Delete(id);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }
    }
}
