namespace avaliacao.digital.circle.Questao1
{
    public interface IGenericRepository<T> where T : Entity
    {
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Deletar(T entity);
    }    

    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        public void Adicionar(T entity)
        {
            throw new NotImplementedException();
        }
        public void Deletar(T entity)
        {
            throw new NotImplementedException();
        }
        public void Atualizar(T entity)
        {
            throw new NotImplementedException();
        }
    }


    public interface IProdutoRepository : IGenericRepository<Produto>
    {
        Produto ObterPorDescricao(string descricao);
    }
        

    public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
    {
        public Produto ObterPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }
        public void Adicionar(Produto entity)
        {
            throw new NotImplementedException();
        }
        public void Deletar(Produto entity)
        {
            throw new NotImplementedException();
        }
        public void Atualizar(Produto entity)
        {
            throw new NotImplementedException();
        }
    }   
}
