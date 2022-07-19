using asp.netWithADO.Models;
using System.Data.SqlClient;

namespace asp.netWithADO.Services
{
    public class StudentServices: IStudentService
    {
        public string Constr { get; set; }
        public IConfiguration _configuration;
        public SqlConnection con;
        public StudentServices(IConfiguration configuration)
        {
            _configuration = configuration;
            Constr = _configuration.GetConnectionString("DBConnection");
        }

        public List<Students> GetStudentsRecord()
        {
            List<Students> studentsList = new List<Students>();

            try {
                using (con = new SqlConnection(Constr))
                {
                    con.Open();
                    var cmd = new SqlCommand("SP_GetRecords",con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Students std = new Students();
                        std.StudentId = Convert.ToInt32(rdr["StudentId"]);
                        std.StudentName = Convert.ToString(rdr["StudentName"]);
                        std.EmailAddress = Convert.ToString(rdr["EmailAddress"]);
                        studentsList.Add(std);
                    }


                }
                return studentsList.ToList();
            } catch(Exception)
            {
                throw;
            }
        }
    }
    public interface IStudentService
    {
        public List<Students> GetStudentsRecord();
    }
}
