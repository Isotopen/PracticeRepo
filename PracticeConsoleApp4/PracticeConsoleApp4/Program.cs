using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Id = 1;
            newCar.Make = "Ford";
            newCar.Model = "Focus";
            newCar.Year = DateTime.Now;

            Car newSuperCar = new SuperCar();
            newSuperCar.Id = 2;
            newSuperCar.Make = "Ford";
            newSuperCar.Model = "Mustang";
            newSuperCar.Year = DateTime.Now;
            ((SuperCar)newSuperCar).HasNos = true;
            ((SuperCar)newSuperCar).HasFins = true;

            var CarCollection = 0;
            while(CarCollection > 0)
            {

            }
        }
    }
}
