using Business.Concrete;
using DataAccess.Concrete.EntityFramewok;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine("Car Name: {0}  Brand Name: {1}  Color Name: {2}",car.CarName, car.BrandName, car.ColorName);
}


