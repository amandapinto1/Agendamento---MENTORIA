using Agendamento.Models;

namespace Agendamento.Data.Repositorios.Interfaces
{
    public interface ISalaRepositorio
    {
        void Adicionar(Sala sala);
        void Remover(Guid id);
        void Atualizar(Sala sala);
        IEnumerable<Sala> Buscar();
        Sala BuscarPorId(Guid id);

        Sala BuscarPorNome(string nome);
    }
}
