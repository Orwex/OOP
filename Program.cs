using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230119___Class_6
{

    class Program
    {

        static void Main(string[] args)
        {
            Vehicles Mercedes = new Vehicles
            {
                year = 2020,
                km = 0.0,
                brand = "Mercedes",
                model = "SAMG"
            };
            Console.WriteLine($"The name of the car {Mercedes.brand} and the model is{Mercedes.model}");
            Console.WriteLine($"The KM of the car is {Mercedes.km} and the year is {Mercedes.year}");
            Console.WriteLine();

            Vehicles Koenigsegg = new Vehicles
            {
                year = 2019,
                km = 1.1,
                brand = "Koenigsegg",
                model = "SXRR"

            };
            Console.WriteLine(Koenigsegg);
            Console.WriteLine(Mercedes);




        }

    }
}

