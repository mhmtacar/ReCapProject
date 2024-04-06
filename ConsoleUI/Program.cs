using Business.Concrete;
using DataAccess.Concrete.EntityFramewok;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Storage.Json;

//CarManager carManager = new CarManager(new EfCarDal());

//var result = carManager.GetCarDetails();

//if (result.Success == true)
//{
//    foreach (var car in result.Data)
//    {

//        Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName);

//    }
//}

//else
//{
//    Console.WriteLine(result.Message);
//}
RentalManager rentalManager = new RentalManager(new EfRentalDal());

var addedRental = rentalManager.Add(new Rental
{
    CustomerId = 3,
    CarId = 5,
    RentDate = DateTime.Now
});

Console.WriteLine(addedRental.Message);

var deliveredCar = rentalManager.CarDeliver(3);
Console.WriteLine(deliveredCar.Message);
