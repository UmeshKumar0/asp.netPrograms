using MySql.Data.MySqlClient;
using System.Data;
using TaskUserAdmin.Models;
using TaskUserAdmin.Service;
namespace TaskUserAdmin.DataAccess
{
    public class BusinessLogic : IServices
    {
        readonly Const data = new Const();
        MySqlConnection con = new MySqlConnection();
        readonly MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private byte ab;
        private byte bc;
        private byte cd;
        private byte de;
        private byte ef;
        private byte fg;
        private byte gh;
        private byte hi;

        public bool ConnectToData(Login acc)  // Verifing User For Login
        {
           con =  data.ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select Email from UserTable where Email ='" + acc.Email + "' and Password ='" + acc.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public List<Login> UserList1() // Showing List of Users
        {
            List<Login> list = new List<Login>();
            con = data.ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select UserId , Name , Email from UserTable";
            MySqlDataAdapter d = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            con.Close();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Login
                {
                    UserId = Convert.ToInt32(item["UserId"]),
                    Name = (string)item["Name"],
                    Email = (string)item["Email"],

                });



            }
            return list;
        }

        public List<Map> ConnectToPermission(int ID)  // Showing Permissions Data
        {
            List<Map> list = new List<Map>();
            con = data.ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select MapId , UserId , ModuleId  from MapTable where UserId =" + ID + " ";
            MySqlDataAdapter d = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            con.Close();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Map
                {
                    MapId = Convert.ToInt32(item["MapId"]),
                    UserId = Convert.ToInt32(item["UserId"]),
                    ModuleId = Convert.ToInt32(item["ModuleId"]),
                }) ;
            }
            return list;
        }

        public bool Complete(int Id, bool CanCreate, bool CanRead, bool CanWrite, bool CanDelete , bool CanCreate1 , bool CanWrite1 ,bool CanRead1 , bool CanDelete1)  //Posting Permissions in Database
        {
            con = data.ConnectionString();
            con.Open();
            ab = Convert.ToByte(CanCreate);
            bc = Convert.ToByte(CanWrite);
            cd = Convert.ToByte(CanRead);
            de = Convert.ToByte(CanDelete);
            ef = Convert.ToByte(CanCreate1);
            fg = Convert.ToByte(CanWrite1);
            gh = Convert.ToByte(CanRead1);
            hi = Convert.ToByte(CanDelete1);
            com.Connection = con;
            com.CommandText = @"Update MapTable SET Read1 = " + cd + ",Write1 = " + bc + ",Create1 = " + ab + ",Delete1 = " + de + " where UserId ="+Id +" AND ModuleId = 1 ;Update MapTable SET Read1 = " + gh + ",Write1 = " + fg + ",Create1 = " + ef + ",Delete1 = " + hi + " where UserId =" + Id + " AND ModuleId = 2";
            var recs = com.ExecuteNonQuery();
            if (recs != 0)
            {

                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool CreatingUser(string Email , string Pass , string Name , int Role)  // Creating User in User Table
        {
            con = data.ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = @"INSERT INTO UserTable (Name, Email , Password , RoleId) VALUES ('"+Name+"', '"+Email+"','"+Pass+"',"+Role+");";
            var recs = com.ExecuteNonQuery();
            if (recs != 0)
            {

                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
    }

