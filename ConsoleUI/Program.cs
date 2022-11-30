
using Business.Concrete;
using DataAccess.Concrete.InMemory;

Console.WriteLine();

CarManager carManager = new CarManager(new InMemoryDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

