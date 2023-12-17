using Domain.Entities;
using Domain.Interfaces.Services.Turma;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase {
        private readonly ITurmaService _service;

        public TurmaController(ITurmaService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Turma>>> GetAll() {
            try {
                var response = await _service.GetAll();

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Turma>> GetSingle(int id) {
            try {
                var response = await _service.GetSingle(id);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Turma>> Insert([FromBody] Turma turma) {
            try {
                var response = await _service.Insert(turma);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult<Turma>> Update([FromBody] Turma turma) {
            try {
                var response = await _service.Update(turma);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Turma>> Delete(int id) {
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
