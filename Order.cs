using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAPTOP_STORE22.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Select Laptop")]
        public int LaptopId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [DataType(DataType.Text)]
        public int ClientName { get; set; }

        [Required(ErrorMessage = "street is required")]
        [DataType(DataType.Text)]
        public int Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [DataType(DataType.Text)]
        public int City { get; set; }

        public int State { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [DataType(DataType.Text)]
        public int Country { get; set; }

        [Required(ErrorMessage = "ZipCode is required")]
        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public int Email { get; set; }


    }
}
