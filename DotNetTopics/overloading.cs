using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTopics
{
    public class overloading
    {
        public string Name(string s1, string s2)
        {
            string FullName = s1 + s2;
            return FullName;
        }

        public string Name(string s1, string s2, string s3)
        {
            string FullName = s1 + s2 + s3;
            return FullName;
        }
        static void Main(string[] args)
        {
            overloading O = new overloading();

            string FullNames = O.Name("shaik", "shameema");
            string FullNames1 = O.Name("shaik", "Anjum","Shahi");
            Console.WriteLine("sum of the two "
                              + "integer value : " + FullNames,FullNames1);
        }


 

    }
}
