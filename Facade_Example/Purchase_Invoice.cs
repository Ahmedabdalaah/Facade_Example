using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Example
{
    internal class Purchase_Invoice
    {
        public double discount = 0;
        public double amount = 0;
        public double netTotal = 0;
        public Purchase_Invoice createInov(Shopping shopping ,string custom_info)
        {
            var invoice = new Purchase_Invoice();
            var items = shopping.GetItems();
            foreach ( BasketItem item in items )
            {
                invoice.amount += item.Item_price + item.Item_quantity;
            }
            // applying discount
            if( items.Count >2 )
            {
                invoice.discount = 15;
            }
            invoice.netTotal = invoice.netTotal - invoice.discount;
            return invoice;
        }
    }
}
