using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;

namespace Tesha_s_Coffee_Shop.DL
{
    class CoffeShopDL
    {
        public static void storeintoFile(string path, MenuItem menu)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(menu.getitemName() + "," + menu.getitemType() + "," + menu.getitemPrice() );
            f.Flush();
            f.Close();
        }
        public static List<MenuItem> readFromFile(string path)
        {
            List<MenuItem> menuList = new List<MenuItem>();
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string itemName = splittedRecord[0];
                    string itemType= splittedRecord[1];
                    int itemPrice = int.Parse(splittedRecord[2]);
                    MenuItem menu = new MenuItem(itemName, itemType, itemPrice);
                    menuList.Add(menu);
                }
                f.Close();
                return menuList;
            }
            else
            {
                return null;
            }
        }
        public static void storeOrderInFile(string path,String item)
        {

            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(item);
            f.Flush();
            f.Close();
        }
        public static List<string> readOrderFromFile(string path)
        {
            List<string> orders = new List<string>();
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    orders.Add(record);
                }
                f.Close();
                return orders;
            }
            else
            {
                return null;
            }
        }
        
    }
}
