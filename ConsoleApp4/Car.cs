using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1km;
        public int Millage;

        
        public Car(string brand, string model, int currentFuel, int fuelFor1Km, int millage) //BUTUN PARAMETRLERIN DAXIL OLUNACAGI HALI NEZERE ALDIM
        {
            this.Brand = brand;
            this.Model = model;
            this.CurrentFuel = currentFuel;
            this.FuelFor1km = fuelFor1Km;
            this.Millage = millage;
        }


        public void Drive(int km)
        {
            int requiredFuel = km * FuelFor1km;
            if (CurrentFuel >= requiredFuel)
            {
                CurrentFuel -= requiredFuel;
                Millage += km;
                Console.WriteLine($"surusden sonraki kilometraj: {Millage} km");
                Console.WriteLine($"surus erzinde istifade olunan benzin: {requiredFuel} l");
                Console.WriteLine($"surusden sonraki qalan benzin: {CurrentFuel} l");
            }
            else
            {
                Console.WriteLine("Kifayet qeder benzininiz yoxdur : ERROR ");
            }
        }
    }
}
