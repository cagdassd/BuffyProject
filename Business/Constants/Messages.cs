﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım yapılıyor";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string TransactionAdded = "Satış işlemi Gerçekleşti";
        public static string TransactionDeleted = "Satış işlemi iptal edildi";
        public static string TransactionUpdated = "Satış işlemi güncellendi";

        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted = "Kategori Silindi";
        public static string CategoryUpdated = "Kategori Güncellendi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 60 ürün olabilir";
        public static string ProductNameExistsError = "Aynı ürün ismine sahip bir ürün daha bulunmakta";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklenemiyor";

        public static string ProductImageAdded = "Fotoğraf Eklendi";
        public static string ProductImageDeleted = "Fotoğraf Silindi";
        public static string ProductImageUpdated = "Fotoğraf güncellendi";

        public static string AuthorizationDenied = "Yetkiniz yetersiz";

        public static string UserRegistered = "Üye kayıt oldu";
        public static string UserNotFound = "Üye bulunamadı";
        public static string PasswordError = "Üye bulunamadı";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı";
        public static string UserAlreadyExists = "Böyle bir üye zaten mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
