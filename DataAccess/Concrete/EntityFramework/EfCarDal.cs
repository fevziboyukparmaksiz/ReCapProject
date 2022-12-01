using DataAccess.Abstract;
using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDbContext>, ICarDal
    {
        public List<CarBrandColorDTO> GetCarDetails()
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join color in context.Colors
                             on c.ColorId equals color.Id
                             select new CarBrandColorDTO()
                             {
                                 CarName = c.Description,
                                 BrandName = b.Name,
                                 ColorName = color.Name,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();
            }
        }
    }
}
