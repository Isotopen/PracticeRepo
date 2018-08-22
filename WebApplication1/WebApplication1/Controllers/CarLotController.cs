using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarLotController : Controller
    {
        // GET: CarLot
        public ActionResult Index()
        {
            ViewBag.CarIndex = 0;

            DealerCarLot dealerCarLot = new DealerCarLot();
            dealerCarLot.Name = "Code Louisville cars";
            dealerCarLot.Cars = new List<Car>();

            for(int i = 0; i <= 99; i++)
            {
                Car car = new Car()
                {
                    Brand = "BMW" + "." + i.ToString(),
                    Color = "Blue" + "." + i.ToString(),
                };

                dealerCarLot.Cars.Add(car);
            }

            return View(dealerCarLot);
        }
    }
}