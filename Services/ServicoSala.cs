using Agendamento.Data.Repositorios.Interfaces;
using Agendamento.Models;
using Agendamento.Services.Dtos.Request;
using Agendamento.Services.Interfaces;

namespace Agendamento.Services
{
    public class ServicoSala : IServicoSala
    {
        private readonly ISalaRepositorio _salaRepositorio;

        public ServicoSala(ISalaRepositorio salaRepositorio)
        {
            _salaRepositorio = salaRepositorio;
        }
        public void Adicionar(SalaRequest salaRequest)
        {
            var salaExistente = _salaRepositorio.BuscarPorNome(salaRequest.Nome);

            if (salaExistente != null)
                throw new Exception("Já existe uma sala cadastrada com esse nome");

            var sala = new Sala(
                salaRequest.Nome,
                salaRequest.Andar,
                salaRequest.QuantidadeDeLugares);

            _salaRepositorio.Adicionar(sala);
        }

        public List<Sala> Buscar()
        {
            return _salaRepositorio.BuscarTodos();
        }

        public void Editar(Guid id, AtualizarSalaRequest request)
        {
            var sala = _salaRepositorio.BuscarPorId(id);
            if (sala is null)
                throw new Exception("Sala inexistente.");

            sala.AlterarNome(request.Nome);
            sala.AlterarQuantidadeDeLugares(request.QuantidadeDeLugares);

            _salaRepositorio.Atualizar(sala);
        }

        public void Remover(Guid id)
        {
            var sala = _salaRepositorio.BuscarPorId(id);

            if (sala is null)
                throw new Exception("");

            _salaRepositorio.Remover(sala);
        }
    }
}
