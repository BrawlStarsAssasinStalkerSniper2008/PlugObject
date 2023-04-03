using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5
{
    internal interface IItemsRepisitiry : IRepository<Items>
    {
        List<Items> GetAllItemsByPrice(int price);
    }
}
