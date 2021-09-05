using LAPTOP_STORE22.Models;
using LAPTOP_STORE22.Services;
using LAPTOP_STORE22.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LAPTOP_STORE22.Controllers
{
    public class HomeController : Controller
    {
        // List<Laptops> _laptops;
        IRepository<Laptops> _LaptopRepo;
        IRepository<Carousel> _CarouselRepo;
        public HomeController(IRepository<Laptops> laptops,IRepository<Carousel> carousel)
        {
           // _laptops = new List<Laptops>();
            _LaptopRepo = laptops;
            _CarouselRepo = carousel;
        }

        public IActionResult Index()
        {
            HomeInsexViewModel model = new HomeInsexViewModel()
            {
                laptops = _LaptopRepo.GetAll(),
                carousels = _CarouselRepo.GetAll()
            };
           
            return View(model);
        }
        [HttpGet]
        public IActionResult AddLaptop()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddLaptop(Laptops laptops)
        {
            if (ModelState.IsValid)
            {Laptops item = new Laptops()
            {
                Id = _LaptopRepo.GetAll().Max(m => m.Id) + 1,
                Name = laptops.Name,
                Brand = laptops.Brand,
                Price = laptops.Price,
                Image = laptops.Image
            };
            _LaptopRepo.Add(item);
            return RedirectToAction("Index");
            }
            else
            {
                return View();
            } 
        }

        
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Order(int? id)
        {
            if(id!=null&& id > 0)
            {
                OrderViewModel model = new OrderViewModel()
                {
                    LaptopToOrder = _LaptopRepo.Get((int)id),
                    OrderDetails = new Order()
                    {
                        LaptopId = (int)id
                    }
                };
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Order(int id,Order orderDetails)
        {
            if (ModelState.IsValid)
            {
                if (_LaptopRepo.GetAll().Count(x => x.Id == orderDetails.LaptopId) >= 1)
                {
                    return RedirectToAction("ThankYou");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View(new OrderViewModel()
                {
                    OrderDetails = orderDetails,
                    LaptopToOrder = _LaptopRepo.Get(id)
                });
            }
        }
        public IActionResult ThankYou()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            Laptops laptops = _LaptopRepo.Get(id);
            return View(laptops);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
