using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 300000, ModelYear = 2005, Description = "Car 1"},
                new Car {CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 450000, ModelYear = 2008, Description = "Car 2"},
                new Car {CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 600000, ModelYear = 2013, Description = "Car 3"},
                new Car {CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 750000, ModelYear = 2020, Description = "Car 4"},
                new Car {CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 900000, ModelYear = 2024, Description = "Car 5"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carsToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.Description = car.Description;
            carsToUpdate.ModelYear = car.ModelYear;
        }
    }
}
