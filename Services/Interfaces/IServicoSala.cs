using Agendamento.Services.Dtos.Request;

namespace Agendamento.Services.Interfaces
{
    public interface IServicoSala
    {
        public void Adicionar(SalaRequest salaRequest);
    }
}
