using Domain.Entities;
using Domain.Interfaces.Services.Disciplina;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase {
        private readonly IDisciplinaService _service;
        public DisciplinaController(IDisciplinaService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Disciplina>>> GetAll() {
            try {
                var response = await _service.GetAll();

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Disciplina>> GetSingle(int id) {
            try {
                var response = await _service.GetSingle(id);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Disciplina>> Insert([FromBody] Disciplina disciplina) {
            try {
                var response = await _service.Insert(disciplina);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult<Disciplina>> Update([FromBody] Disciplina disciplina) {
            try {
                var response = await _service.Update(disciplina);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Disciplina>> Delete(int id) {
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
