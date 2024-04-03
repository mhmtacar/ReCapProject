using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class CarMessages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarListed = "Arabalar listelendi";
        public static string CarGetById = "İstenilen Id'ye sahip araba getirildi";
        public static string CarNameMinimumLength = "Araba ismi minimum 2 karakter olmalıdır";
        public static string CarDailyPriceMinimumValue = "Araba günlük fiyatı 0'dan büyük olmalıdır";
        public static string CarDetails = "Arabalar marka ve renk bilgileriyle birlikte listelendi";
        public static string CarsFilteredWithBrandId = "İstenilen marka Id'sine sahip arabalar listelendi";
        public static string CarsFilteredWithColorId = "İstenilen color Id'sine sahip arabalar listelendi";
        public static string CarsFilteredWithPrice = "İstenilen fiyat aralığındaki arabalar listelendi";
    }
}
