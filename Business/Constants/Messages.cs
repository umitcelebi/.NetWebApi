using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded   = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string CategoryAdded   = "Category başarıyla eklendi.";
        public static string CategoryDeleted = "Category başarıyla silindi.";
        public static string CategoryUpdated = "Category başarıyla güncellendi.";
        
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola yanlış.";
        public static string SuccessfulForLogin = "Giriş Başarılı.";

        public static string UserRegistered = "kullanıcı başarıyla kaydedildi.";

        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";
    }
}
