    using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _car;
        public InMemoryDal()
        {
            _car= new List<Car>
            {
                new Car { Id = 1, BrandId= 1, ColorId = 1, DailyPrice=15000, Description="Honda", ModelYear = 2013 },
                new Car { Id = 2, BrandId= 2, ColorId = 2, DailyPrice=35000, Description="Ferrari", ModelYear = 2016 },
                new Car { Id = 3, BrandId= 3, ColorId = 3, DailyPrice=10000, Description="BMW", ModelYear = 2019 }
            };

        }
    
        public void Add(Car car)
        {
            _car.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=> c.Id == car.Id);
            _car.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            carToDelete.Id = car.Id;
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;
            carToDelete.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c=>c.Id== carId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarBrandColorDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}