using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTopics
{
    interface Products
    {
        void ShowProductData();
        void DisplayProductData(int Id, string Name, double price, int Quality);
    }
    interface Customers
    {
        void ShowCustomerData();
        void DisplayContomerData(int custId, string name, string email, int Age, long number);
    }

    public class Amazon : Products, Customers
    {

        void Products.DisplayProductData(int Id, string Name, double price, int Quality)
        {
            Console.WriteLine(Id + "\n" + Name + "\n" + price + "\n" + Quality);
        }

        void Products.ShowProductData()
        {
            Console.WriteLine("Here Product Data to show:");  
        }

        void Customers.ShowCustomerData()
        {
            Console.WriteLine("Here Customer Data to show");
        }

        void Customers.DisplayContomerData(int custId, string name, string email, int Age, long number)
        {
            Console.WriteLine(custId + "\n" + name + "\n" + email + "\n" + Age + "\n" + number);
        }

    }

    public class FlipCart : Products, Customers
    {

        void Products.DisplayProductData(int Id, string Name, double price, int Quality)
        {
            Console.WriteLine(Id + "\n" + Name + "\n" + price + "\n" + Quality);
        }

        void Products.ShowProductData()
        {
            Console.WriteLine("Here Product Data to show:");
        }

        void Customers.ShowCustomerData()
        {
            Console.WriteLine("Here Customer Data to show");
        }

        void Customers.DisplayContomerData(int custId, string name, string email, int Age, long number)
        {
            Console.WriteLine(custId + "\n" + name + "\n" + email + "\n" + Age + "\n" + number);
        }

    }

    public class TestInterfaces
    {
        static void Main()
        {
            Products products = new Amazon();
            Customers customers = new FlipCart();

            products.ShowProductData();
           
            products.DisplayProductData(1,"Fridge",15000,1);
            products.DisplayProductData(2, "LapTop", 45000, 1);
            products.DisplayProductData(3, "HeadPhone", 5000, 1);
            products.DisplayProductData(4, "Washing Machine", 10000, 1);
            products.DisplayProductData(5, "Air Conditioner", 25000, 1);
            products.DisplayProductData(6, "MicroOven", 4000, 1);

            customers.ShowCustomerData();
           
            customers.DisplayContomerData(11,"rani","rani123@gmail.com",25,7869054321);
            customers.DisplayContomerData(12, "raju", "raju123@gmail.com", 24, 8690543217);
            customers.DisplayContomerData(13, "ramesh", "ramesh123@gmail.com", 23, 6869054321);
            customers.DisplayContomerData(14, "renuka", "renuka123@gmail.com", 22, 5869054321);
            customers.DisplayContomerData(15, "sailaja", "sailaja123@gmail.com", 26, 9869054321);
            customers.DisplayContomerData(16, "vasmi", "vasmi123@gmail.com", 28, 7869054321);

            Console.ReadLine();
        }
    }

}
