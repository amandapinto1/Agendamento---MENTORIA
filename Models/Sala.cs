namespace Agendamento.Models
{
    public class Sala : Entidade
    {
        public string Nome { get; set; }
        public int QuantidadeDeLugares { get; set; }
        public int Andar { get; set; }
        public bool Status { get; set; }
        public IReadOnlyCollection<Reserva> Reservas => _reservas;
        public List<Reserva> _reservas;
        public Sala(string nome, int quantidadeDeLugares, int andar)
        {
            Nome = nome;
            QuantidadeDeLugares = quantidadeDeLugares;
            Andar = andar;
            Status = true;

            _reservas = new List<Reserva>();
        }

        private Sala() { }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("O nome não pode estar vazio");

            Nome = nome;
        }

        public void AlterarQuantidadeDeLugares(int quantidade)
        {
            if (quantidade <= 0)
                throw new Exception("Não é possível definir a quantidade de lugares com o valor informada");
            
            QuantidadeDeLugares= quantidade;
        }
        public void TornarAtivo()
        {
            Status = true;
            
            
        }
        public void TornarInativo()
        {
            Status = false;
            
        }
        public bool ReservaExistente(Reserva reserva)
        {
            if (reserva != null) return _reservas.Any(x => x.Id == reserva.Id);
            return false;

        }

        public void AdicionarReserva(Reserva reserva)
        {
            if (!ReservaExistente(reserva)) return;
            _reservas.Add(reserva);
        }

        public void RemoverReserva(Reserva reserva)
        {
            if (!ReservaExistente(reserva)) return;

            var reservaNaLista = _reservas.First(x => x.Id == reserva.Id);
            _reservas.Remove(reservaNaLista);
        }
        public void EditarReserva(Reserva reserva)
        {
            if (!ReservaExistente(reserva)) return;

            var reservaNaLista = _reservas.First(x => x.Id == reserva.Id);
            _reservas.Remove(reservaNaLista);
            _reservas.Add(reserva);
        }
    }
}

