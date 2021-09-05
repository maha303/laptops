using LAPTOP_STORE22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAPTOP_STORE22.ViewModels
{
    public class HomeInsexViewModel
    {
        public IEnumerable<Laptops> laptops { get; set; }
        public IEnumerable<Carousel> carousels { get; set; }
    }
}
