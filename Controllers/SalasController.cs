using Agendamento.Services.Dtos.Request;
using Agendamento.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Agendamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalasController : ControllerBase
    {
        private readonly IServicoSala _servicoSala;
        public SalasController(IServicoSala servicoSala)
        {
            _servicoSala = servicoSala;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] SalaRequest salaRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Entidade Inválida");
                _servicoSala.Adicionar(salaRequest);

                return Ok();

            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }

        // Método indepotente
        [HttpGet]
        public IActionResult Buscar()
        {
            try
            {

                return Ok(_servicoSala.Buscar());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult Atualizar([FromRoute] Guid id, [FromBody] AtualizarSalaRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Entidade Inválida");

                _servicoSala.Editar(id, request);
                    return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remover([FromRoute] Guid id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Entidade Inválida");

                _servicoSala.Remover(id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
