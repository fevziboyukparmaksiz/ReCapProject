
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

Console.WriteLine();

//Car();

//GetCarsByBrandId();

//GetCarDetails();

static void Car()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetCarsByBrandId(5))
    {
        Console.WriteLine(car.Description);
    }
}

static void GetCarsByBrandId()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetCarsByBrandId(1))
    {
        Console.WriteLine(car.Description);
    }
}

static void GetCarDetails()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.GetCarDetails())
    {
        Console.WriteLine(car.BrandName+" : "+ car.CarName+" : " + car.ColorName +" : "+car.DailyPrice);
    }
}