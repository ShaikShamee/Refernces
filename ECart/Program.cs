using System;

namespace ECart
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";

            for (; answer == "yes";)
            {

                Console.WriteLine("Enter Product to get ProductsData");
                Console.WriteLine("Enter Item to get ItemsData");

                string str = Console.ReadLine();

                switch (str)
                {
                    case "Product":
                        Product.Products p = new Product.Products();
                        p.prodId = 101;
                        p.prodName = "fridge";
                        p.prodPrice = 25000;
                        p.Quantatity = 1;
                        p.DisplayAllProdData();
                        break;
                    case "Item":
                        Items.Items item = new Items.Items();
                        item.ItemId = 11;
                        item.ItemCount = 25;
                        item.ItemQuality = 2;
                        item.DisplayItems();
                        break;
                    default:
                        Console.WriteLine("No Data Available for Items and Products");
                        break;
                }
                
            }
            Console.ReadLine();
        }
    }
}

