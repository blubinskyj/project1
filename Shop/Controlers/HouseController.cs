using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controlers
{
    public class HouseController : Controller
    {
        private readonly IAllHouse _allCars;
        private readonly IHouseCategory _allCategorys;

        public HouseController(IAllHouse iAllCars, IHouseCategory iCarsCat) 
        {
            _allCars = iAllCars;
            _allCategorys = iCarsCat;
        }

        public ViewResult List()
        {
            var cars = _allCars.Cars;
            return View(cars);        
        }
    }
}
