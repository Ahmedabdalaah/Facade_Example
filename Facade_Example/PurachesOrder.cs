using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Example
{
    internal class PurachesOrder
    {
        public bool CreateOrder(Shopping shooping, string client_info)
        {
            bool isExist = true;
            Inventory inven = new Inventory();
            foreach (var item in shooping.GetItems())
            {
                if (!inven.CheckItem(item.Item_id, item.Item_quantity))
                    isExist = false;
            }

            if (isExist)
            {
                // Create Inventory Order
                InventoryOrder inventoryOrder = new InventoryOrder();
                inventoryOrder.CreateOrder(shooping, "123");

                // Create Invoice 
                Purchase_Invoice invoice = new Purchase_Invoice();
                var inv = invoice.createInov(shooping, "address:246,id=123,email=hjjjj");

                // Payment
                PaymentProcess payment = new PaymentProcess();
                payment.HandlePayment(inv.netTotal, "acc=123456789");

                // Send email
                EmailNotification email = new EmailNotification();
                email.SendEmail("2312", "Invoice Created");

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
