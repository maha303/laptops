using LAPTOP_STORE22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAPTOP_STORE22.Services
{
    public class MockLaptopsRepository : IRepository<Laptops>
    {
        List<Laptops> _laptops;
        public MockLaptopsRepository()
        {
            _laptops = new List<Laptops>() {
                new Laptops()
                {
                    Id = 1,
                    Name = "MacBookPro16-inch",
                    Brand = "Apple",
                    Price = 3500.99,
                    Image = "mac16.jpg"
                },
                 new Laptops()
                 {
                     Id = 2,
                     Name = "MacBookPro13-inch",
                     Brand = "Apple",
                     Price = 1450.99,
                     Image = "mac13.jpg"
                 },
                  new Laptops()
                 {
                     Id = 3,
                     Name = "MacBookAir13-inch",
                     Brand = "Apple",
                     Price = 1400.99,
                     Image = "air13.jpg"

                 },
             new Laptops()
                 {
                     Id = 4,
                     Name = "Huawei",
                     Brand = "Huawei",
                     Price = 800.99,
                     Image = "hawawi.jpg"

                 },new Laptops()
                 {
                     Id = 5,
                     Name = "Microsoft 15-inch",
                     Brand = "Microsoft",
                     Price = 800.99,
                     Image = "micro15.jpg"

                 },
            new Laptops()
                 {
                     Id = 6,
                     Name = "Microsoft Servics",
                     Brand = "Microsoft",
                     Price = 800.99,
                     Image = "microserves13.jpg"

                 },};
        }
    
        public bool Add(Laptops item)
        {
            try
            {
                Laptops laptops = item;
                laptops.Id = _laptops.Max(x => x.Id)
                    + 1;
                _laptops.Add(item);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Laptops item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Laptops item)
        {
            throw new NotImplementedException();
        }

        public Laptops Get(int id)
        {
            return _laptops.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Laptops> GetAll()
        {
            return _laptops.ToList();
        }
    }
}
