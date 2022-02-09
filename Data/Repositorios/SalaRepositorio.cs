using Agendamento.Data.Repositorios.Interfaces;
using Agendamento.Models;

namespace Agendamento.Data.Repositorios
{
    public class SalaRepositorio : ISalaRepositorio
    {
        private readonly AgendamentoContexto _context;
        public SalaRepositorio(AgendamentoContexto context)
        {
            _context = context;
        }
        public void Adicionar(Sala sala)
        {
            _context.Salas.Add(sala);
            _context.SaveChanges();
        }

        public void Atualizar(Sala sala)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();

        }

        public IEnumerable<Sala> Buscar()
        {
            throw new NotImplementedException();
        }

        public Sala BuscarPorId(Guid id)
        {
            return _context.Salas.FirstOrDefault(sal => sal.Id == id);
        }

        public Sala BuscarPorNome(string nome)
        {
            return _context.Salas.FirstOrDefault(sal => sal.Nome == nome);

        }
    }
}
