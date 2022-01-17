namespace Agendamento.Models
{
    public class Sala : Entidade
    {
        public string Nome { get; set; }
        public int QuantidadeDeLugares { get; set; }
        public int Andar { get; set; }
        public bool Status { get; set; }

        public Sala(string nome, int quantidadeDeLugares, int andar)
        {
            Nome = nome;
            QuantidadeDeLugares = quantidadeDeLugares;
            Andar = andar;
            Status = true;
        }

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
    }
}
