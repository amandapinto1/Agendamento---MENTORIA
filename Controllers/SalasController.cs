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
    }
}
