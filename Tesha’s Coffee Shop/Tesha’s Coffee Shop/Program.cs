using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.UI;
using Tesha_s_Coffee_Shop.DL;




namespace Tesha_s_Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Menu.txt";
            string path1 = "Orders.txt";
            CoffeeShop coffeeshop = new CoffeeShop("Tesha’s Coffee Shop",path,path1);
            int option = 0;
            while (option != 9)
            {
                Console.Clear();
                HelperUI.header();
                option = HelperUI.menu();
                if (option == 1)
                {
                    HelperUI.header();
                    MenuItem item = MenuItemUI.addMenu();
                    CoffeShopDL.storeintoFile(path, item);
                    string status =coffeeshop.addmenuItem(item);
                    CoffeeShopUI.show(status);
                }
                else if (option == 2)
                {
                    HelperUI.header();
                    MenuItem item=coffeeshop.cheapestItem();
                    if(item!=null)
                    CoffeeShopUI.viewCheapItem(item);
                }
                else if (option == 3)
                {
                    HelperUI.header();
                    List<string> drinks = coffeeshop.drinksOnly();
                    CoffeeShopUI.showList(drinks);
                }
                else if (option == 4)
                {
                    HelperUI.header();
                    List<string> food = coffeeshop.foodOnly();
                    CoffeeShopUI.showList(food);
                }
                else if (option == 5)
                {
                    HelperUI.header();
                    string item = CoffeeShopUI.menuOrder();
                    CoffeShopDL.storeOrderInFile(path1,item);
                    string order=coffeeshop.addOrder(item);
                    CoffeeShopUI.show(order);

                }
                else if (option == 6)
                {
                    HelperUI.header();
                    string fullfil_status = coffeeshop.fulfillOrder();
                    CoffeeShopUI.show(fullfil_status);
                }
                else if (option == 7)
                {
                    HelperUI.header();
                    List<string> orderList = coffeeshop.getOrderList();
                    CoffeeShopUI.showList(orderList);

                }
                else if (option == 8)
                {
                    HelperUI.header();
                    int totalAmount = coffeeshop.dueAmount();
                    CoffeeShopUI.show($"The total payable amount is :{totalAmount}");
                }
                HelperUI.stopScreen();
            }
        }
        

    }
}
