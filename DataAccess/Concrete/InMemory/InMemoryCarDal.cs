using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private Cars carToDelete;
        List<Cars> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Cars>
            {
            new Cars{  Id = 1, BrandId = 1, ModelYear = 2015, DailyPrice = 300, Description = "Mercesdes" },
            new Cars { Id = 2, BrandId = 1, ModelYear = 2016, DailyPrice = 400, Description = "Ford" },
            new Cars { Id = 3, BrandId = 2, ModelYear = 2017, DailyPrice = 500, Description = "Fiat" },
            new Cars { Id = 4, BrandId = 3, ModelYear = 2018, DailyPrice = 600, Description = "Audi" },
            new Cars { Id = 5, BrandId = 3, ModelYear = 2019, DailyPrice = 700, Description = "BMW" },

            };
        }

        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }


        public List<Cars> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == carToDelete.BrandId).ToList();
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
