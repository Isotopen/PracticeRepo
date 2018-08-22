using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Id = 1;
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = DateTime.Now;

            Car mySuperCar = new SuperCar();
            mySuperCar.Id = 2;
            mySuperCar.Make = "Mazda";
            mySuperCar.Model = "Miata";
            //mySuperCar.HasNos = true; This is one way to do this
            SuperCar myActualSuperCar = (SuperCar)mySuperCar;

            myActualSuperCar.HasNos = true;
            myActualSuperCar.HasFin = true;

            //Way to set property This is a second way to do the same thing using casting
            ((SuperCar)mySuperCar).HasNos = true;
            ((SuperCar)mySuperCar).HasFin = true;
        }
    }
}
