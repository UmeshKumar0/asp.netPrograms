using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ToDoListProgramSP.Controllers;
using ToDoListProgramSP.Models;

namespace ToDoListProgramSP.BusinessLayer
{
    public class ToDo
    {
        public string InsertData(ToDoList objcust)
        {
            SqlConnection con = null;

            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("ToDoList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@CustomerID", 0);    
                cmd.Parameters.AddWithValue("@Title", objcust.Title);
                cmd.Parameters.AddWithValue("@TimeSpend", objcust.TimeSpend);
                cmd.Parameters.AddWithValue("@Query", 1);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return result = "";
            }
            finally
            {
                con.Close();
            }
        }

        internal string InsertData(ToDoListController ToDo)
        {
            throw new NotImplementedException();
        }

        public string UpdateData(ToDoList objcust)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("ToDoList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", objcust.ID);
                cmd.Parameters.AddWithValue("@Title", objcust.Title);
                cmd.Parameters.AddWithValue("@TimeSpend", objcust.TimeSpend);
                cmd.Parameters.AddWithValue("@Query", 2);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return result = "";
            }
            finally
            {
                con.Close();
            }
        }
        public int DeleteData(String ID)
        {
            SqlConnection con = null;
            int result;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("ToDoList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Title", null);
                cmd.Parameters.AddWithValue("@TimeSpend", null);
                cmd.Parameters.AddWithValue("@Query", 3);
                con.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {
                return result = 0;
            }
            finally
            {
                con.Close();
            }
        }
        public List<ToDoList> Selectalldata()
        {
            SqlConnection con = null;
            DataSet ds = null;
            List<ToDoList> custlist = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("ToDoList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", null);
                cmd.Parameters.AddWithValue("@Title", null);
                cmd.Parameters.AddWithValue("@TimeSpend", null);
                cmd.Parameters.AddWithValue("@Query", 4);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                custlist = new List<ToDoList>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ToDoList cobj = new ToDoList();
                    cobj.ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"].ToString());
                    cobj.Title = ds.Tables[0].Rows[i]["Title"].ToString();
                    cobj.TimeSpend = Convert.ToInt32(ds.Tables[0].Rows[i]["TimeSpend"].ToString());

                    custlist.Add(cobj);
                }
                return custlist;
            }
            catch
            {
                return custlist;
            }
            finally
            {
                con.Close();
            }
        }

        public ToDoList SelectDatabyID(string ID)
        {
            SqlConnection con = null;
            DataSet ds = null;
            ToDoList cobj = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                SqlCommand cmd = new SqlCommand("ToDoList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Title", null);
                cmd.Parameters.AddWithValue("@TimeSpend", null);
                cmd.Parameters.AddWithValue("@Query", 5);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cobj = new ToDoList();
                    cobj.ID = Convert.ToInt32(ds.Tables[0].Rows[i]["CustomerID"].ToString());
                    cobj.Title = ds.Tables[0].Rows[i]["Name"].ToString();
                    cobj.TimeSpend = Convert.ToInt32(ds.Tables[0].Rows[i]["Address"].ToString());
}
                return cobj;
            }
            catch
            {
                return cobj;
            }
            finally
            {
                con.Close();
            }

        }
    }
}