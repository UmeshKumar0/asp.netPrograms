using APIwithDatabase.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIwithDatabase.database_access_layer
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        customers cs = new customers();

        public void Add_Customer(customers cs)

        {

            SqlCommand com = new SqlCommand("Sp_Customer_Add", con);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@FullName", cs.Fullname);

            com.Parameters.AddWithValue("@Email", cs.Email);

            com.Parameters.AddWithValue("@Password", cs.Password);

            com.Parameters.AddWithValue("@Mobile_no", cs.Mobileno);

            com.Parameters.AddWithValue("@Creatd_At", DateTime.Now);

            con.Open();

            com.ExecuteNonQuery();

            con.Close();



        }
    }
}