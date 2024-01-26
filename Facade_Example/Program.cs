// See https://aka.ms/new-console-template for more information
using Facade_Example;
Shopping basket =new Shopping ();
basket.AddItem(new BasketItem { Item_id = "123", Item_price = 20, Item_quantity = 5 });
basket.AddItem(new BasketItem { Item_id = "234", Item_price = 50, Item_quantity = 2 });
basket.AddItem(new BasketItem { Item_id = "523", Item_price = 100, Item_quantity = 1 });
basket.AddItem(new BasketItem { Item_id = "246", Item_price = 50, Item_quantity = 6 });
PurachesOrder order = new PurachesOrder();
order.CreateOrder(basket,"name:Ahmed,visa:123456789,mobile:0100000");
              