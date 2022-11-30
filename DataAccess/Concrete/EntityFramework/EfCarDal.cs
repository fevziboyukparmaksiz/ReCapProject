using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var added = context.Entry(entity);
                added.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State=EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                return filter==null ? 
                    context.Set<Car>().ToList() : 
                    context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var updated = context.Entry(entity);
                updated.State=EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
