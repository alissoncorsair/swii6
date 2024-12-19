using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/atividades")]
    [ApiController]
    public class AtividadesController : Controller
    {
        private readonly AtividadesRepository _repository;

        public AtividadesController(AtividadesRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Atividade atividade)
        {
            _repository.Create(atividade);
            return Created("", new object { });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Find(int id)
        {
            var atividade = await _repository.GetById(id);
            return Ok(atividade);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var atividades = await _repository.GetAll();
            return Ok(atividades);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Atividade atividade)
        {
            _repository.Update(id, atividade);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}
