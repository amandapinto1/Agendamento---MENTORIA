namespace Agendamento.Models
{
    public class Reserva : Entidade
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Inicio{ get; set; }
        public DateTime Fim { get; set; }
        public Guid SalaId { get; set; }
        public Guid UsuarioId { get; set; }

        public Reserva(string titulo, string descricao, DateTime inicio, DateTime fim, Guid salaid, Guid usuarioid)
        {
            Titulo = titulo;
            Descricao = descricao;
            Inicio = inicio;
            Fim = fim; 
            SalaId = salaid;
            UsuarioId = usuarioid;
        }

    }
}
