using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAPTOP_STORE22.Models
{
    public class Laptops
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required ")]
        [Display(Name ="Laptops Name "),MinLength(2,ErrorMessage ="Minimum lenght is 2 chars ")]
        public String Name { get; set; }
        public string Brand { get; set; }
        [DataType(DataType.Currency,ErrorMessage ="Please enter correct price.")]
        public  double Price { get; set; }
        public string Image { get; set; }
    }
}
