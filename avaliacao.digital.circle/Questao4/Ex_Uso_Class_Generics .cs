using Dapper;
using System.Data.SqlClient;

namespace Avaliacao.Digital.Circle.Questao4
{
    public static class ExemploDeUso
    {
        public static void Executar()
        {
            var tipo1 = Query<Tipo1>("SELECT * FROM Tipo1", null);
            var tipo2 = Query<Tipo2>("SELECT * FROM Tipo2", null);
            var tipo3 = Query<Tipo3>("SELECT * FROM Tipo3", null);
        }

        public static List<T> Query<T>(string sql, object parametros)
        {
            using (var connection = new SqlConnection(""))
            {
                return connection.Query<T>(sql, parametros)?.ToList();
            }
        }
    }
}


public class Tipo1
{    
    public int Id { get; set; }
}
public class Tipo2
{
    public int Id { get; set; }
}
public class Tipo3
{
    public int Id { get; set; }
}