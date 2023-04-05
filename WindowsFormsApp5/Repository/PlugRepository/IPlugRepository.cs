using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5.Repository.PlugRepository
{
    internal interface IPlugRepisitiry : IRepository<Items>
    {
        //List<Items> GetAllItemsByPrice(int price);
    }
}
