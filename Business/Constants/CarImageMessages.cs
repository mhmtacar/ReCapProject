using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class CarImageMessages
    {
        public static string ImageAdded = "İstenilen arabaya ait fotoğraf başarıyla eklendi.";
        public static string CarImageDeleted = "İstenilen araba fotoğrafı başarıyla silindi";
        public static string ImagesListedById = "İstenilen Id'ye sahip araba fotoğrafı başarıyla getirildi.";
        public static string ImageUpdated = "İstenilen araba fotoğrafı başarıyla güncellendi.";
        public static string ImagesListed = "Arabalara ait fotoğraflar başarıyla listelenmiştir.";
        public static string ImagesListedByCarId = "İstenilen arabaya ait fotoğraflar başarıyla listelenmiştir.";
        public static string CarImageLimitReached = "Bir arabanın en fazla 5 fotoğrafı olabilir.";
        public static string CarImageNotFound = "Verilen arabaya ait fotoğraf bulunamadı.";
    }
}
