using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StoreBoxes
{
    public class Box

    {
        public string SerialNumber { get; set; }
        public Item Item { set; get; }
        public int ItemQuantity { get; set; }
        public double Price {  get; set; }

        public Box(string serialNumbers, Item item, int count)
        {
            SerialNumber = serialNumbers;
            Item = item;
            ItemQuantity = count;
            Price = count * Item.Price;
        }
    }
}
