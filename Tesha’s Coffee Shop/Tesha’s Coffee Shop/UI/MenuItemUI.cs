using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesha_s_Coffee_Shop.BL
{
    class MenuItemUI
    {
       
        public static MenuItem addMenu()
        {
            Console.Write("Enter Item Name: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter Item type: ");
            string itemType = Console.ReadLine();
            Console.Write("Enter Item Price: ");
            
            int itemPrice = int.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(itemName, itemType, itemPrice);
            return item;
        }
    }
}
