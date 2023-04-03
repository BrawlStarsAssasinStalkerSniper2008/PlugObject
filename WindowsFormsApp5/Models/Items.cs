using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Models
{
    internal class Items
    {
        public int ID;
        public int PlugID;
        public int Cost;
        public int Weight;
        public string ItemName;

        public override string ToString() 
        {
            return $"Name:{ItemName} ID:{ID} Cost:{Cost} Plug ID:{PlugID} Weight:{Weight}";
        }
    }
}
