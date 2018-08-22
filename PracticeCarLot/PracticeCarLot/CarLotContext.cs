using ConsoleApp3;
using System;
using System.Data.Entity;

namespace PracticeCarLot
{
    public class CarLotContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public int SeedData { get; set; }

        public CarLotContext()
        {
            if (Cars = 0)
            { Car newCar = new Car(); }
            else
            {
                Console.WriteLine(Cars);
            }
            
        }
    }
}
