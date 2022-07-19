using System.Data;
using System.Data.SqlClient;

namespace CrudADONet.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=employeeADO1;Integrated Security=True");
        public DataSet Empget(Employee emp ,out string msg ) { 
                DataSet ds = new DataSet();
             msg = "";
        
            try {
                SqlCommand com = new SqlCommand("Sp_Employee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Sr_no", emp.Sr_no);
                com.Parameters.AddWithValue("@Emp_name", emp.Emp_name);
                com.Parameters.AddWithValue("@City", emp.City);
                com.Parameters.AddWithValue("@flag", emp.flag);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                msg = "OK";
                return ds;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
                return ds;
            }
            
        }
        public string Empdml(Employee emp, out string msg)
      {
            msg = "";

            try
            {
                SqlCommand com = new SqlCommand("Sp_Employee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Sr_no", emp.Sr_no);
                com.Parameters.AddWithValue("@Emp_name", emp.Emp_name);
                com.Parameters.AddWithValue("@City", emp.City);
                com.Parameters.AddWithValue("@flag", emp.flag);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                msg = "OK";
                return msg;
            }
            catch (Exception ex)
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                msg = ex.Message;
                return msg;
            }

        }
    }
}
