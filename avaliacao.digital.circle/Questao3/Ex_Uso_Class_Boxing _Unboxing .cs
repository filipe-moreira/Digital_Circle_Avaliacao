namespace Avaliacao.Digital.Circle.Questao3
{
    public static class ExemploDeUso
    {
        public static void Executar()
        {
            // Boxing
            // Convertendo um tipo de valor para um objeto
            int numero = 100;
            object objeto = numero;

            // Unboxing
            // Convertendo o objeto de volta para o tipo de valor
            int numeroDesempacotado = (int)objeto;
        }
    }
}