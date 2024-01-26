using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Example
{
    internal class Shopping
    {
        private List<BasketItem> items = new List<BasketItem>();
        public void AddItem (BasketItem item)
        {
            items.Add(item);
        }
        public void RemoveItem (string item_id)
        {
            var item = items.Where(x => x.Item_id == item_id).Single();
            if(item.Item_quantity >0 )
            {
                item.Item_quantity = item.Item_quantity- 1;
            }
        }
        public List<BasketItem> GetItems ()
        {
            return items;
        }
    }
}
