using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Products
    {
        public int prodId { get; set; }
        public string prodName { get; set; }

        public int prodPrice { get; set; }

        public int Quantatity { get; set; }

        //private int _number;

        //public int Number
        //{
        //    get
        //    {
        //        return _number;
        //    }
        //    set
        //    {
        //        _number = value;
        //    }
        //}

         public void DisplayAllProdData()
        {
            Console.WriteLine("ProductId :" +prodId +"\n"+"ProductName :"+prodName+"\n"+"ProuctPrice:" +prodPrice+"\n"+"Quantatity:"+ Quantatity);
        }

    }
}
