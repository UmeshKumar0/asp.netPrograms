using MySql.Data.MySqlClient;

namespace TaskUserAdmin.DataAccess
{
    public class Const
    {
        MySqlConnection con = new MySqlConnection();
        public MySqlConnection ConnectionString()  // ConnectionString
        {
            con.ConnectionString = "server = development-db.cuihkv7hgfys.ap-south-1.rds.amazonaws.com,3306; user = umesh_training; password = password; database = arrosoft";
            return con;
        }

    }
}
