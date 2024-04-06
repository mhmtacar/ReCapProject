using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class RentalMessages
    {
        public static string RentalAdded = "Araba kiralama işlemi eklendi";
        public static string RentalInvalid = "Kiralama işlemi başarısız!";
        public static string RentalDeleted = "Araba kiralama işlemi silindi";
        public static string RentalUpdated = "Araba kiralama işlemi güncellendi";
        public static string RentalListed = "Araba kiralamaları listelendi";
        public static string RentalGetById = "İstenilen Id'ye sahip kiralanan araba getirildi";
        public static string RentalDetails = "Kİralanan arabalar araba ve müşteri bilgileriyle birlikte listelendi";
        public static string CarDeliver = "Araç teslim edilmiştir";
        public static string CarDeliverEmpty = "Araç teslim edilememiştir. Belirtilen bilgide araç bulunmamaktadır!";

    }
}
