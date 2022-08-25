using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTopics
{
    public class Calculator
    {
        //private static int _resultStorage = 0;

        //public static string Type = "Arithmetic";

        //public static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //public static void Store(int result)
        //{
        //    _resultStorage = result;
        //    Console.WriteLine(_resultStorage);
        //}
       static void Main(string[] args)
        {

            Books Book1 = new Books();
            Books Book2 = new Books();
            Book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
            Book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);
                Book1.display();
                Book2.display();

            //    var result = Calculator.Sum(10, 25);
            //    Calculator.Store(result);
            //    Console.WriteLine(result);
            //    var calcType = Calculator.Type;
            //    Calculator.Type = "Scientific";

            //    Console.WriteLine(calcType);
            Console.ReadLine();
        }


          public struct Books
          {
            private string title;
            private string author;
            private string subject;
            private int bookid;

              public void getValues(string t, string a, string s, int id)
              {
                title = t;
                author = a;
                subject = s;
                bookid = id;
              }

              public void display()
              {
                Console.WriteLine("Title : {0}", title);
                Console.WriteLine("Author : {0}", author);
                Console.WriteLine("Subject : {0}", subject);
                Console.WriteLine("Book_id :{0}", bookid);
              }
          }
    }
}
     
 


