using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Cars> GetAll();
        void Add(Cars car);
        void Delete(Cars car);
        void Update(Cars car);
        List<Cars> GetById(int brandId);


    }
}
