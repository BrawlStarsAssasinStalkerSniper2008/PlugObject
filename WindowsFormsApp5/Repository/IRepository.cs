using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal interface IRepository<TValue>
    {
        List<TValue> GetAll();
        int Insert(TValue items);
        int Update(int id, TValue items);
    }
}
