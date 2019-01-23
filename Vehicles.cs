using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230119___Class_6
{
    class Vehicles
    {
        public int year;
        public double km;
        public string brand;
        public string model;

        public string Tellmeyourmodel()
        {
            return model;
        }
        public void drive()
        {

        }
        public void start()
        {

        }
        public double Tellmeyourkm()
        {
            return km;
        }

        public override string ToString()
        {
            return $"Brand = {brand} Model = {model} KM {km} Year = {year}";
        }
    }
}
