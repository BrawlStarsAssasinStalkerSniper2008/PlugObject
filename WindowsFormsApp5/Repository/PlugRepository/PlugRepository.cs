using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5.Repository.PlugRepository
{
    internal class PlugRepository : IPlugRepisitiry
    {

            private string connectionstring { get; set; }
            public PlugRepository(string host, string database, string user, string password)
            {
                connectionstring = "Database" + database + "DataSourse" + host + "Password" + password + "User" + user;
            }
            public List<Plug> GetAll()
            {
                List<Plug> allPlugs = new List<Plug>();
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand queryCommand = conn.CreateCommand();
                queryCommand.CommandText = connectionstring = "SELECT * FROM PlugProduct.Items";
                try
                {
                    conn.Open();
                    MySqlDataReader reader;
                    reader = queryCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allPlugs.Add(new Plug { ID = reader.GetInt32(0), Name = reader.GetString(1), Surname = reader.GetString(2), PhoneNumber = reader.GetString(3) });
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return allPlugs;
            }

            public int Insert(Plug plug)
            {
                int rows = 0;
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand insertCommand = conn.CreateCommand();
                insertCommand.CommandText = $"INSERT INTO PlugProduct.Items(name, Surname, ID, PhoneNumber) VALUES ({plug.Name}, {plug.Surname}, {plug.ID}, {plug.PhoneNumber})";
                try
                {
                    conn.Open();
                    rows = insertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    conn.Close();
                }
                return rows;
            }

            public int Update(int id, Plug plug)
            {
                int rows = 0;
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand insertCommand = conn.CreateCommand();
                insertCommand.CommandText = $"UPDATE PlugProduct.Plug SET name = {plug.Name}, ID = {plug.ID}, surname = {plug.Surname}, PhoneNumber = {plug.PhoneNumber})";
                try
                {
                    conn.Open();
                    rows = insertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    conn.Close();
                }
                return rows;
            }
        }
    
}
