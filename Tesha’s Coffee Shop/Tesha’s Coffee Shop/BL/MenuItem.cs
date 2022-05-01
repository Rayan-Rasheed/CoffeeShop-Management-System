using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesha_s_Coffee_Shop.BL
{
    class MenuItem
    {
        private string itemName;
        private string itemType;
        private int itemPrice;
        public MenuItem(string itemName, string itemType, int itemPrice)
        {
            this.itemName = itemName;
            this.itemType = itemType;
            this.itemPrice = itemPrice;
        }
        public string getitemName()
        {
            return itemName;
        }
        public string getitemType()
        {
            return itemType;
        }
        public int getitemPrice()
        {
            return itemPrice;
        }
    }
}
