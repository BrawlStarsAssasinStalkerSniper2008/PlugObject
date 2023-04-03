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
        }

        public List<Items> GetAllItemsByPrice(int price)
        {
            throw new NotImplementedException();
        }

        public int Insert(Items items)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, Items items)
        {
            throw new NotImplementedException();
        }
    }
}
