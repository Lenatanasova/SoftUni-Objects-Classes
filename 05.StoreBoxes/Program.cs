using _05.StoreBoxes;
using System.Diagnostics.Metrics;
using System.Xml;

namespace _05.StoreBoxes
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            List <Box> boxesList = new List <Box> ();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] boxInfo = input.Split();

                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                double itemPrice = double.Parse(boxInfo[3]);
      
                Item item = new Item(itemName, itemPrice);

                Box box = new Box(serialNumber, item, itemQuantity);

                boxesList.Add(box);

                input = Console.ReadLine();
            }

            List <Box> sortedBoxesList = boxesList.OrderByDescending(box => box.Price).ToList();

            foreach (Box box in sortedBoxesList)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }

        }
    }
}
