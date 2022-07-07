using apiForMyndPage.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiForMyndPage.Controllers
{
    public class TandCController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"select  EMP_ID ,EMPNAME , Questions from  dbo.QuestionT ";
            DataTable table = new DataTable();
            using(var con = new SqlConnection(ConfigurationManager.ConnectionStrings["TandCDatabase"].ConnectionString))
                using(var cmd = new SqlCommand(query,con))
                using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
        public string Post(TandC tandC)
        {
            try
            {
                string query = @"insert into dbo.Employee values('" + tandC.EMPNAME + @"','" + tandC.Extramile + @"','" + tandC.Creative + @"','" + tandC.ImproveWork + @"','" + tandC.Fellow + @"','" + tandC.WorkUP + @"','" + tandC.OtherComments + @"')";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["TandCDatabase"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Added Successfully !!";
            }
            catch (Exception)
            {
                return " Failed To add !!";
            }
        }
        
      

    }
}
