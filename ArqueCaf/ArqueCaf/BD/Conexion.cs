using MySql.Data.MySqlClient;


namespace ArqueCaf
{
    class BDConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=Arquecaf; Uid=root; pwd=coldplay99;");
            conectar.Open();
            return conectar;
        }
    }
}
