using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WebAppl_todo.Models;
using Microsoft.Extensions.Configuration;

namespace WebAppl_todo.Bussiness_Layer
{
    public class BussinessLayer 
    {
        public IConfigurationRoot ConfigureServices()
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json")
            .Build();
            return configuration;
        }
        public List<List> List() {
            List<List> people = new List<List>();
            IConfigurationRoot configuration = ConfigureServices();
            using (MySqlConnection con = new MySqlConnection(configuration.GetConnectionString("myDb1")))
            {
                try
                {
                    con.Open();

                    //table selection
                    MySqlCommand cmd = new MySqlCommand("select id,title ,time_spend ,created_at from dhurvTask where is_deleted=0", con);
                   
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //  read database
                    while (reader.Read())
                    {
                        List person = new List();
                        person.id = Convert.ToInt32(reader["id"]);
                        person.title = Convert.ToString(reader["title"]);
                        person.time_spend = Convert.ToInt32(reader["time_spend"]);

                        //local time
                        var time = Convert.ToDateTime(reader["created_at"]);
                        DateTime created_at = (time.ToLocalTime());
                        person.created_at = created_at;


                        people.Add(person);
                    }

                    reader.Close();
                }

                catch (Exception connectionLost)
                {
                    Console.WriteLine("error in connection" + connectionLost);
                }
                finally
                {
                    con.Close();
                }
            }
            return (people);
        }
        
        public JsonResult DeleteAll()
        {

            IConfigurationRoot configuration = ConfigureServices();
            using (MySqlConnection con = new MySqlConnection(configuration.GetConnectionString("myDb1")))
            {
                try
                {
                    con.Open();
                    MySqlCommand command;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string sql = "update dhurvTask set is_deleted = 1";
                    command = new MySqlCommand(sql, con);
                    adapter.UpdateCommand = new MySqlCommand(sql, con);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();

                    if(adapter.Equals(true))
                    {
                        return new JsonResult("Task Deleted Successfully");
                    }
                    else
                    {
                        return new JsonResult("Task Deleted UnSuccessfully");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return new JsonResult(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            

        }

        

        public JsonResult Delete(int id)
        {

            IConfigurationRoot configuration = ConfigureServices();
            using (MySqlConnection con = new MySqlConnection(configuration.GetConnectionString("myDb1")))
            {
                try
                {
                    con.Open();
                    MySqlCommand command;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string sql = "update dhurvTask set is_deleted=1 where id=" + id;
                    command = new MySqlCommand(sql, con);
                    adapter.UpdateCommand = new MySqlCommand(sql, con);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                    if (adapter.Equals(true))
                    {
                        Console.WriteLine("Successfull");
                    }
                    else
                    {
                        Console.WriteLine("UnSuccessfull");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return new JsonResult("Task Deleted Successfully");
        }




        
        public JsonResult Update(int id, string title, int time_spend)
        {
            IConfigurationRoot configuration = ConfigureServices();
            using (MySqlConnection con = new MySqlConnection(configuration.GetConnectionString("myDb1")))
            {
                try
                {
                    con.Open();
                    MySqlCommand command;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string sql = "update dhurvTask set title='" + title + "' , time_spend =" + time_spend + " , modified_at=now() where id=" + id + "";
                    command = new MySqlCommand(sql, con);
                    adapter.UpdateCommand = new MySqlCommand(sql, con);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                    if (adapter.Equals(true))
                    {
                        Console.WriteLine("Successfull");
                    }
                    else
                    {
                        Console.WriteLine("UnSuccessfull");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return new JsonResult("Task Updated Successfully");
        }


        [HttpPost]
        public JsonResult Insert(string title, int time_spend)
        {
            IConfigurationRoot configuration = ConfigureServices();
            using (MySqlConnection con = new MySqlConnection(configuration.GetConnectionString("myDb1")))
            {
                try
                {
                    con.Open();
                    MySqlCommand command;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string sql = "insert into dhurvTask(title,time_spend,created_at,modified_at,is_deleted) values('" + title + "'," + time_spend + ", now(),now(),0)";
                    command = new MySqlCommand(sql, con);
                    adapter.InsertCommand = new MySqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    con.Close();
                    if (adapter.Equals(true))
                    {
                        Console.WriteLine("Successfull");
                    }
                    else
                    {
                        Console.WriteLine("UnSuccessfull");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return new JsonResult("Task Inserted Successfully");
        }

    }
}

   



    

