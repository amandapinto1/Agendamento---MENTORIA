namespace Agendamento.Models
{
    public class Usuario : Entidade
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Permissao { get; set; }

        public Usuario(string nome, string email, string senha, string permissao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Permissao = permissao;            
        }
    }
}
