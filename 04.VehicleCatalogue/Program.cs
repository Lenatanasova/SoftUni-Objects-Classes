using System.Reflection;
using System.Text;

namespace _04.VehicleCatalogue
{
    public class Program
    {
       public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalogue catalogue = new Catalogue();

            while (input != "end")
            {
                string[] data = input.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int powerOrWeight = int.Parse(data[3]);

                if (type == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = powerOrWeight
                    };
                    catalogue.CarList.Add(car);
                }
                else
                {
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = powerOrWeight
                    };
                    catalogue.TruckList.Add(truck);
                }

                input = Console.ReadLine();
            }

            List <Car> sortedCars = catalogue.CarList.OrderBy(car => car.Brand).ToList();
            List <Truck> sortedTrucks = catalogue.TruckList.OrderBy(truck => truck.Brand).ToList();

            if ( sortedCars.Count > 0 )
            {

                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }
            if ( sortedTrucks.Count > 0 )
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }



        }
    }
}
