using LAPTOP_STORE22.Services;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAPTOP_STORE22.Models
{
    public class MockCarouselRepository : IRepository<Carousel>
    {
        List<Carousel> _carousels;
        public MockCarouselRepository()
        {
            _carousels = new List<Carousel>();
            _carousels.Add(new Carousel()
            {
                Id = 0,
                Title = "Dell 15-inch",
                Description = "Price 6,449 $",
                ImageURL = "dell15_1.jpg"


            });
            _carousels.Add(new Carousel()
            {
                Id = 2,
                Title = "HP 13-Da2026Nx",
                Description = "Price 6,449 $",
                ImageURL = "hp13.jpg"


            });
            _carousels.Add(new Carousel()
            {
                Id = 0,
                Title = "ASUSA ZenBook",
                Description = "Price 6,449 $",
                ImageURL = "ausus.jpg"


            });
        }
        public bool Add(Carousel item)
        {
            try
            {
                Carousel carousel = item;
                carousel.Id = _carousels.Max(x => x.Id)
                    + 1;
                _carousels.Add(item);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Carousel item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Carousel item)
        {
            throw new NotImplementedException();
        }

        public Carousel Get(int id)
        {
            return _carousels.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Carousel> GetAll()
        {
            return _carousels.ToList();
        }
    }
}
