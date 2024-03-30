using Business.Concrete;
using DataAccess.Concrete.EntityFramewok;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Console.WriteLine("Bütün araba listesi");
foreach (var car in carManager.GetAll())
{
    Console.WriteLine("Car Name: " + car.CarName);
}
Console.WriteLine("-----------");

Console.WriteLine("Marka Id'si 1 olan arabaların listesi");
foreach (var car in carManager.GetCarsByBrandId(1))
{
    Console.WriteLine("Car Name: " + car.CarName);
}
Console.WriteLine("-----------");

Console.WriteLine("Color Id'si 2 olan arabaların listesi");
foreach (var car in carManager.GetCarsByColorId(2))
{
    Console.WriteLine("Car Name: " + car.CarName);
}
Console.WriteLine("-----------");

Console.WriteLine("Price'ı 1500000 ile 2000000 arasında olan arabaların listesi");
foreach (var car in carManager.GetCarsByPrice(1500000,2000000))
{
    Console.WriteLine("Car Name: " + car.CarName);
}

//Console.WriteLine("-----------");
//Car car2 = carManager.GetById(3);
//Console.WriteLine("Car Id'si 3 olan arabanın bilgileri");
//Console.WriteLine("Car Id : " + car2.CarId + "  Brand Id : " + car2.BrandId + "  Color Id : " + car2.ColorId + "  Car Description : " + car2.Description + "  Model year : " + car2.ModelYear + "  Price : " + car2.DailyPrice);


//Console.WriteLine("-----------");
//Car car3 = new Car { CarId = 5, BrandId = 1, ColorId = 4, DailyPrice = 1200000, Description = "Car 5 Updated", ModelYear = 2010 };
//carManager.Update(car3);
//Console.WriteLine("CarId'si 5 olan arabayı güncelledikten sonra arabaların listesi");
//printCarInfos(carManager);

//Console.WriteLine("-----------");
//carManager.Delete(car3);
//Console.WriteLine("CarId'si 5 olan arabayı sildikten sonra arabaların listesi");
//printCarInfos(carManager);

//Console.WriteLine("-----------");
//Car car4 = new Car { CarId = 6, BrandId = 2, ColorId = 3, CarName = "a", DailyPrice = 1500000, Description = "Car 6", ModelYear = 2022 };
//carManager.Add(car4);
//Console.WriteLine("CarId'si 6 olan yeni bir araba ekledikten sonra arabaların listesi");
//printCarInfos(carManager);

static void printCarInfos(CarManager carManager)
{
    foreach (var car in carManager.GetAll())
    {
        //Console.WriteLine("Car Id : " + car.CarId + "  Brand Id :" + car.BrandId + "  Color Id : " + car.ColorId + "  Car Name: " + car.CarName + "  Car Description : " + car.Description + "  Model year : " + car.ModelYear + "  Price : " + car.DailyPrice);
        Console.WriteLine("Car Name: " + car.CarName);
    }
}