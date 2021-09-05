using LAPTOP_STORE22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAPTOP_STORE22.ViewModels
{
    public class OrderViewModel
    {
        public Laptops LaptopToOrder { get; set; }
        public Order OrderDetails { get; set; }
    }
}
