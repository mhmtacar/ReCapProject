using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandGetById = "İstenilen Id'ye sahip marka getirildi";

        public static string ImageAdded = "İstenilen arabaya ait fotoğraf başarıyla eklendi.";
        public static string CarImageDeleted = "İstenilen araba fotoğrafı başarıyla silindi";
        public static string ImagesListedById = "İstenilen Id'ye sahip araba fotoğrafı başarıyla getirildi.";
        public static string ImageUpdated = "İstenilen araba fotoğrafı başarıyla güncellendi.";
        public static string ImagesListed = "Arabalara ait fotoğraflar başarıyla listelenmiştir.";
        public static string ImagesListedByCarId = "İstenilen arabaya ait fotoğraflar başarıyla listelenmiştir.";
        public static string CarImageLimitReached = "Bir arabanın en fazla 5 fotoğrafı olabilir.";
        public static string CarImageNotFound = "Verilen arabaya ait fotoğraf bulunamadı.";

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

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorGetById = "İstenilen Id'ye sahip renk getirildi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerGetById = "İstenilen Id'ye sahip müşteri getirildi";
        public static string CustomerDetails = "Müşteriler kullanıcı bilgileriyle birlikte listelendi";
        public static string CustomersFilteredWithUserId = "İstenilen kullanıcı Id'sine sahip müşteriler listelendi";

        public static string RentalAdded = "Araba kiralama işlemi eklendi";
        public static string RentalInvalid = "Kiralama işlemi başarısız!";
        public static string RentalDeleted = "Araba kiralama işlemi silindi";
        public static string RentalUpdated = "Araba kiralama işlemi güncellendi";
        public static string RentalListed = "Araba kiralamaları listelendi";
        public static string RentalGetById = "İstenilen Id'ye sahip kiralanan araba getirildi";
        public static string RentalDetails = "Kİralanan arabalar araba ve müşteri bilgileriyle birlikte listelendi";
        public static string CarDeliver = "Araç teslim edilmiştir";
        public static string CarDeliverEmpty = "Araç teslim edilememiştir. Belirtilen bilgide araç bulunmamaktadır!";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserGetById = "İstenilen Id'ye sahip kullanıcı getirildi";

        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
