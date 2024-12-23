namespace Avaliacao.Digital.Circle.Questao2
{
    public static class ExemploDeUso
    {
        public delegate void Notificacao(string mensagem);
        public static void Executar()
        {
            var centralNotificacoes = new Notificacoes();

            // Criando dois observadores
            var observador1 = new Observador("Observador 1");
            var observador2 = new Observador("Observador 2");

            centralNotificacoes.AdicionarObservador(observador1.Atualizar);
            centralNotificacoes.AdicionarObservador(observador2.Atualizar);

            // Notificando todos os observadores
            centralNotificacoes.NotificarObservadores("Primeira mensagem");

            // Remover observador e notificar novamente
            centralNotificacoes.RemoverObservador(observador1.Atualizar);
            centralNotificacoes.NotificarObservadores("Segunda mensagem");
        }
    }

    public class Notificacoes
    {
        private event ExemploDeUso.Notificacao Observadores;

        public void AdicionarObservador(ExemploDeUso.Notificacao observador)
        {
            Observadores += observador;
        }

        public void RemoverObservador(ExemploDeUso.Notificacao observador)
        {
            Observadores -= observador;
        }

        public void NotificarObservadores(string mensagem)
        {
            Observadores?.Invoke(mensagem);
        }
    }

    public class Observador
    {
        public string Nome { get; }

        public Observador(string nome)
        {
            Nome = nome;
        }

        public void Atualizar(string mensagem)
        {
            Console.WriteLine($"{Nome} recebeu: {mensagem}");
        }
    }
}
