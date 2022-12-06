
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine();



//GetCarsByBrandId();

UserManager userManager = new UserManager(new EfUserDal());

userManager.Add(new User { FirstName = "Fevzi", LastName = "Böyükparmaksız", Email = "asdasda@gmail.com", Password = "12345" });




static void GetCarsByBrandId()
{
    CarManager carManager = new CarManager(new EfCarDal());

    var result = carManager.GetCarsByBrandId(2);
    if (result.Success == true)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine(car.Description);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}


