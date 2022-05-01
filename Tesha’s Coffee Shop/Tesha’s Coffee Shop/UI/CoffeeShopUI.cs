using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;


namespace Tesha_s_Coffee_Shop.UI
{
    class CoffeeShopUI
    {
        static public void viewCheapItem(MenuItem item)
        {
            Console.WriteLine(item.getitemName() + "\t" + item.getitemType() + "\t" + item.getitemPrice());

        }
        static public void showList(List<string> showlist)
        {
            foreach (string var in showlist)
            {
                Console.WriteLine(var);
            }
        }
        static public string menuOrder()
        {
            Console.Write("Enter the menu item you want order: ");
            string item = Console.ReadLine();
            return item;
        }
        static public void show(string item)
        {
            Console.WriteLine(item);
        }
        
    }
}
