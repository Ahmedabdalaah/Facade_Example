using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Example
{
    internal class Inventory
    {
        public bool CheckItem(string item_id , double item_quantity)
        {
            return item_quantity < 50;
        }
    }
}
