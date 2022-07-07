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
            string query = @"select  TermsAndCondition , Description from  dbo.TandC ";
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
                string query = @"insert into dbo.TandC values('" + tandC.TermsAndCondition + @"'," + tandC.Description + @")";

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

        public string Put(TandC tandC)
        {
            try
            {
                string query = @"update dbo.TandC set TermsAndCondition = '" + tandC.TermsAndCondition + @"',Description ='"+ tandC.Description + @"' where id=" + tandC.id+@"";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["TandCDatabase"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Updated Successfully !!";
            }
            catch (Exception)
            {
                return " Failed To update !!";
            }
        }

        public string Delete(int id)
        {
            try
            {
                string query = @"delete from dbo.TandC where id=" + id + @"";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["TandCDatabase"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Deleted Successfully !!";
            }
            catch (Exception)
            {
                return " Failed To delete !!";
            }
        }
    }
}
