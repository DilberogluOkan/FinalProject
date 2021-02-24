using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductInvalid = "Ürün Adı Geçersiz"; 
        public static string MaintenanceTime = "Bakım Zamanı"; 
        public static string ProductListed = "Ürünler Listelendi";

        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductCountOfCategoryError="Kategori sınırı";
        public static string ProductNameAlreadyError="Bu İsimde Başka Bir Ürün Var ";
        internal static string CategoryLimitOfExceded = "Kategori Limiti Aşıldı ";
    }
}
