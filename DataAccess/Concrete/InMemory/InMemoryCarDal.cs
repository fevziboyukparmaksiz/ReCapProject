    using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car { CarId = 1, BrandId= 1, ColorId = 1, DailyPrice=15000, Description="Honda", ModelYear = 2013 },
                new Car { CarId = 2, BrandId= 2, ColorId = 2, DailyPrice=35000, Description="Ferrari", ModelYear = 2016 },
                new Car { CarId = 3, BrandId= 3, ColorId = 3, DailyPrice=10000, Description="BMW", ModelYear = 2019 }
            };

        }
    
        public void Add(Car car)
        {
            _car.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=> c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToDelete.CarId = car.CarId;
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
            return _car.Where(c=>c.CarId== carId).ToList();
        }

       
    }
}