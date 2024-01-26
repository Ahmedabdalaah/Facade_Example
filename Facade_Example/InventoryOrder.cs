using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Example
{
    internal class InventoryOrder  
    {
        public string CreateOrder (Shopping shooping , string store_id)
        {
            shooping.GetItems();
            return $"order number is {System.Guid.NewGuid().ToString()}";
        }
    }
}
