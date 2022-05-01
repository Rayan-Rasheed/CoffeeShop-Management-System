using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.DL;

namespace Tesha_s_Coffee_Shop.BL
{
    class CoffeeShop
    {
        private string shopName;
        private  List<MenuItem> menuList = new List<MenuItem>();
        private  List<string> orderList = new List<string>();
        public CoffeeShop(string shopName,string pathMenu,string pathOrder)
        {
            this.shopName = shopName;
            menuList = CoffeShopDL.readFromFile(pathMenu);
            orderList = CoffeShopDL.readOrderFromFile(pathOrder);
        }
        public  string  addmenuItem(MenuItem item)
        {
            menuList.Add(item);
            return "Add sucessfully!";
        }
       

        public string addOrder(string itemName)
        {
            string order = "Item Unavailable!";
            if (isItemExist(itemName)!=null)
            {
                orderList.Add(itemName);
                order = "Item has been ordered!";
            }
            return order;
        }
       
        public MenuItem isItemExist(string itemName)
        {
            foreach(MenuItem var in menuList)
            {
                if (itemName == var.getitemName())
                {
                    return var;
                }
            }
            return null;
        }
        public string fulfillOrder()
        {
            string item= "All orders have been fulfilled!";
            
            if (orderList.Count > 0)
            {
                string n = orderList[0];
                orderList.Clear();
                item= $"The "+n+" is ready";
            }
            return item;
        }
        public List<string> getOrderList()
        {
            return orderList;
        }
        public int dueAmount()
        {
            int total = 0;
            MenuItem item;
            foreach (string var in orderList)
            {
                item = isItemExist(var);
                if (item != null)
                {
                    total = total + item.getitemPrice();
                }
            }
            return total;
        }
        public MenuItem cheapestItem()
        {
            if (menuList.Count > 0)
            {
                int minPrice = menuList[0].getitemPrice();
                MenuItem item = menuList[0];

                foreach (MenuItem var in menuList)
                {
                    if (var.getitemPrice() < minPrice) item = var;
                }
                return item;
            }
            return null;
        }
        public List<string> drinksOnly()
        {
            List<string> drink=new List<string>();
            foreach (MenuItem var in menuList)
            {
                if (var.getitemType() == "Drink" || var.getitemType() == "drink")
                {
                   drink.Add( var.getitemName());
                }
            }
            return drink;
        }
        public List<string> foodOnly()
        {
            List<string> food = new List<string>();
            foreach (MenuItem var in menuList)
            {
                if (var.getitemType() == "Food" || var.getitemType() == "food")
                {
                    food.Add(var.getitemName());
                }
            }
            return food;
        }


    }
}
