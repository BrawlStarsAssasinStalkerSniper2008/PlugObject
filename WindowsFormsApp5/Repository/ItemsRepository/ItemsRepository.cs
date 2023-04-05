using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5
{
    internal class MySqlItemsRepository : IItemsRepisitiry
    {
        private string connectionstring { get; set; }
        public MySqlItemsRepository(string host, string database, string user, string password)
        {
            connectionstring = "Database" + database + "DataSourse" + host + "Password" + password + "User" + user;
        }
        public List<Items> GetAll()
        {
            List<Items> allItems = new List<Items>();
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand queryCommand = conn.CreateCommand();
            queryCommand.CommandText = connectionstring = "SELECT * FROM PlugProduct.Items";
            try
            {
                conn.Open();
                MySqlDataReader reader;
                reader = queryCommand.ExecuteReader();
                while(reader.Read())
                {
                    allItems.Add(new Items { ID = reader.GetInt32(0), Name = reader.GetString(1), Cost = reader.GetInt32(2), Weight = reader.GetInt32(3), PlugID = reader.GetInt32(2)});
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return allItems;
        }

        public int Insert(Items items)
        {
            int rows = 0;
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand insertCommand= conn.CreateCommand();
            insertCommand.CommandText = $"INSERT INTO PlugProduct.Items(name, cost, plugID, weight, ID) VALUES ({items.Name}, {items.Cost}, {items.PlugID}, {items.Weight}, {items.ID})";
            try
            {
                conn.Open();
                rows = insertCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return rows;
        }

        public int Update(int id, Items items)
        {
            int rows = 0;
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand insertCommand = conn.CreateCommand();
            insertCommand.CommandText = $"UPDATE PlugProduct.Items.Weight SET name = {items.Name}, ID = {items.ID}, Weight = {items.Weight}, Cost = {items.Cost}, plugID = {items.PlugID} WHERE id = {id} )";
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
