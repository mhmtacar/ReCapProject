using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join u in context.Users2
                             on c.UserId equals u.UserId

                             select new RentalDetailDto
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CarName = car.CarName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };
                return result.ToList();
            }
        }
        public void CarDeliver(int rentalId)
        {
            using (var context = new ReCapContext())
            {
                var updatedRental = context.Rentals.SingleOrDefault(r => r.RentalId == rentalId);
                updatedRental.ReturnDate = DateTime.Now;
                context.SaveChanges();
            }
        }
    }
}
