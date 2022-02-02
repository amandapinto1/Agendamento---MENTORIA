namespace Agendamento.Models
{
    public class Reserva : Entidade
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime Inicio{ get; private set; }
        public DateTime Fim { get; private set; }
        public Guid SalaId { get; private set; }
        public Guid UsuarioId { get; private set; }

        public Reserva(string titulo, string descricao, DateTime inicio, DateTime fim, Guid salaid, Guid usuarioid)
        {
            Titulo = titulo;
            Descricao = descricao;
            Inicio = inicio;
            Fim = fim; 
            SalaId = salaid;
            UsuarioId = usuarioid;
        }

        private Reserva() { }

        //EF RELATIONS
        public Sala Sala { get; set; }
        public Usuario Usuario { get; set; }

    }
}
