using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num1
{
    class Transfer
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Train[] trains = new Train[8];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Потяг{i + 1}");
                Console.WriteLine("введіть номер Поізда");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("місто куда прибуде потяг");
                string City = Console.ReadLine();
                Console.Write("Час відправлення: ");
                string departureTime = Console.ReadLine();


                trains[i] = new Train(City, number, departureTime)
                {
                    Destination = City,
                    TrainNumber = number,
                    DepartureTime = departureTime
                };
            } Array.Sort(trains);
            Console.WriteLine("введіть номер потяга");
            int search = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (var train in trains)
            {
                if (search == train.TrainNumber)
                {
                    Console.WriteLine($"номер потяга               :{train.TrainNumber}");
                    Console.WriteLine($"місто куди прибуде потяг   :{train.Destination}");
                    Console.WriteLine($"час відправлення           :{train.DepartureTime}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Поїзд з таким номером не знайдено.");
            }

        }
    }
}












