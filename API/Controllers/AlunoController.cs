using Application.Services;
using Domain.Entities;
using Domain.Interfaces.Services.Aluno;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Aluno>>> GetAll() {
            try {
                var response = await _service.GetAll();

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetSingle(int id) {
            try {
                var response = await _service.GetSingle(id);

                return Ok(response);
            } catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Aluno>> Insert([FromBody] Aluno aluno) {
            try {
                var response = await _service.Insert(aluno);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult<Aluno>> Update([FromBody] Aluno aluno) {
            try {
                var response = await _service.Update(aluno);

                return Ok(response);
            }
            catch (ArgumentException exception) {
                throw;
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Aluno>> Delete(int id) {
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
