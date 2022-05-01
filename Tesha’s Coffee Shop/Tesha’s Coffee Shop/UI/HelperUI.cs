using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesha_s_Coffee_Shop.UI
{
    class HelperUI
    {
        static public void header()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*************************Tesha’s Coffee Shop***********************");
            Console.WriteLine("*******************************************************************");

        }
        public static int menu()
        {
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View the Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink’s Menu");
            Console.WriteLine("4.View the Food’s Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Orders’s List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.WriteLine("Choose option....");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
        public static void stopScreen()
        {
            Console.ReadKey();
        }
    }
}
