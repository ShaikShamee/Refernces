using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Items
    {
        public int ItemId { get; set; }
        public int ItemCount { get; set; }

        public int ItemQuality { get; set; }

        public  void DisplayItems()
        {
            Console.WriteLine("ItemId:"+ItemId+"\n"+"Count"+ItemCount+"\n"+"Quality:"+ItemQuality);
        }


    }
}
