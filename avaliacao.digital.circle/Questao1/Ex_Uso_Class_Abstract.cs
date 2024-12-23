namespace avaliacao.digital.circle.Questao1
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public Entity()
        {
            Id = Guid.NewGuid();
            DataInclusao = DateTime.Now;
        }
    }

    public class Produto : Entity
    {
        public string Descricao { get; private set; }
        public double Preco { get; private set; }
        public Produto(string descricao, double preco)
        {
            Descricao = descricao;
            Preco = preco;
        }
    }
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
