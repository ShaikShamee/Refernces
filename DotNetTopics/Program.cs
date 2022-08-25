using System;

namespace DotNetTopics
{
   public class Program
    {
        //public int Id;
        //public string Name;
        //public string Email;
        //public int Age;

        //public Program(int Id, string Name, string Email, int Age)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Email = Email;
        //    this.Age = Age;
        //}

        //public void  Show()
        //{
        //    Console.WriteLine("id is:"+Id+"\n"+"Name is:"+Name+"\n"+"Email is:"+Email+"\n"+"Age:"+Age);
        //}
        //static void Main(string[] args)
        //{
        //    Program p = new Program(12,"seema","shaikseema@gmail.com",25);
        //    p.Show();
        //    Console.WriteLine(p.Id);
        //    Console.WriteLine(p.Name);
        //    Console.WriteLine(p.Email);
        //    Console.WriteLine(p.Age);
            


        //}

        //public string Name(string s1, string s2)
        //{
        //    string FullName = s1 + s2;
        //    return FullName;
        //}

        //public string Name(string s1, string s2, string s3)
        //{
        //    string FullName = s1 + s2 + s3;
        //    return FullName;
        //}
        //static void Main(string[] args)
        //{
        //    overloading O = new overloading();

        //    string FullNames = O.Name("shaik", "shameema");
        //    string FullNames1 = O.Name("shaik", "Anjum", "Shahi");
        //    Console.WriteLine("sum of the two  string :"+ FullNames+"\n"+"Sum of the three string"+ FullNames1);
        //}
        static void Main(string[] args)
        {

            string[] weekDays;
            weekDays = new string[] {"Sun", "Mon", "Tue", "Wed","Thu", "Fri", "Sat"};
            Console.WriteLine("Weekdays are :");
            foreach (string day in weekDays)
            {
                Console.Write(day + "\n");
            }

            string[,] str = new string[4, 2] { { "one", "two" },
                                            { "three", "four" },
                                            { "five", "six" },
                                            { "seven", "eight" } };

            Console.WriteLine(" String elements is:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(str[i, j] + "\n");
                }
            }


        }

    }
}
