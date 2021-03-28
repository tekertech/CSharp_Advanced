using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string  STACK vs HEAP
            /* 
             * string : referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
             *          Ram'in Heap bölgesinde tutulur.
             *          String değerler HEAP'te tutulur. String referans/degiskenler lar ise STACK te tutulur.
             */

            string name    = "";   //  RAM -> STACK,     RAM ->  HEAP  yer ayırma işlemi gerçekleşti.
            string surname = null; //  RAM -> STACK      YOK         yer ayırma işlemi gerçekleşti.
            #endregion
            #region Null - Empty Durumları, Farkları 
            #region Null
            // Bir değişken/nullable/referans eğer ki null alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.
            // Arsa yok
            // Değer türlü değişkenler null alamazlar!
            // Null alabilen türler sadece referans türlerdir
            // Değer Türlü değişkenlerin null alabilmesi için nullable(?) olmaları gerekmektedir.

            int? number = null;
            string name22 = null;
            #endregion
            #region Empty
            // Bir değişken/nullable/referans eğer ki empty alıyorsa bu durum ilgili değişkenin değeri yok anlamına gelir. Fakat bir alanı tahsisinde bulunulmuştur.
            // Arsa var , Ev yok
            // Tüm değerlere empty atanabilir. Default değerlerin olduğu durumlar empty olarak geçerler.
            int a = 0; bool flag = false;
            string ad = string.Empty; // Heap 'de alan tahsisinde bulundu ve ""  değeri atıldı
            string soyad = null;      // Heap 'de alan tahsisinde bulunmadı. Null bellekte yer kaplamaz.

            //  Null olan bir değer üzerinde işlem yapılamaz.  RunTime hatası alınır. Empty olan bir değer üzerinde işlem yapılabilir.
            #endregion
            #region IsNullOrEmpty, IsNullOrWhiteSpace
            //  string  ifadeler kullanılmadan önce kesinlikle kontrol edilmelidir çünkü bunlar runtime hatası veriyor.
            string city = "";

            if (string.IsNullOrEmpty(city)) 
            {
                Console.WriteLine("IsNullOrEmpty = True");
            }
            else if(string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine("IsNullOrWhiteSpace = True"); 
            }
            #endregion
            #endregion
            #region String - char Dizisi - Format, Escape Karakterler, Verbatim Strings
            /*
             *  1-) String ifadeler özünde bir char dizisi olmasından dolayı referans türlü değişkenlerdi. çünkü diziler referans türlüdür. 
             *  2-) indexer operatörünü kullanabiliriz. Dizilere ait özellikleri burda kullanabilriz.
             *  3-) String özünde bir char dizisi olabilir ama yapısal olarak yinede string olduğu için direkt Array referansına atanamazlar.
             *  4-) Bir string ifade ile herhangi bir tür + operatörü ile işleme tabi tutulabilir.
             *  5-) $(String Interpolation) c# 6.0  yapısal oalrak arka planda string.Format fonksiyonu ile şekillenen bir operatördür.
             *  6-) Escape/Kacış kartakterleri : Eğer ki string için ozel eylemsel mahiyet ifade eden bir karakter metinsel olarak kullanacaksak Özel karakter olmadığını ifade etmemiz gerekir. \
             *       \a, \b \t \r \n \" \' \ 
             *  7-) Verbatim (@)     
             *  8-) $(Interpolation) ile @ (Verbatim) in birlikte kullanımı @$ c# 8.0
             */

            string metin = "sebebsiz boş yere ayrılacaksan...";
            Array array = metin.ToCharArray(); // 3. madde 

            metin = $"Merhaba {metin} ";
            metin = string.Format("Merhaba  {0}", 12);

            int sayi = 14;
            string numberName = "Ogrenciler  eli\nize sağlık";
            numberName = (numberName + sayi);

            // Verbatim
            int @void = 45;

            string ogrenci = @"Merhbaa 
                                     asdsadsad
                asdasdsad ";

            Console.WriteLine(@void);


            #endregion
            #region String Fonksiyonları
            /*
             * 1-) Contains, StartsWith, EndsWith, Equals, IndexOf, Insert, remove,replace, split, substring, ToLowwer, ToUpper, Trim, TrimEnd, TrimStart
             *     Compare: 
             *            0  --> Her iki değer birbirine eşittir.
             *            1  --> Soldaki sağındakinde alfanumeric olarak büyük
             *           -1  --> Soldaki sağındakinde alfanumeric olarak küçük
             */
            string soz = "laylaylom galiba sana göre sevmeler";
            
            Console.WriteLine(soz.Contains("Sana"));
            Console.WriteLine(soz.StartsWith("laylay"));
            Console.WriteLine(soz.EndsWith("ler"));
            Console.WriteLine(soz.Equals("laylaylom galiba sana göre sevmeler"));

            Console.WriteLine(soz.CompareTo("a"));
            Console.WriteLine(string.Compare(soz, "a"));
            Console.WriteLine(soz.IndexOf("sana"));
            string aaaa = soz.Insert(21, " VAN ");
            aaaa.Remove(21, 5);
            Console.WriteLine(aaaa.Remove(21, 5));
            Console.WriteLine(soz.Replace("la", "A"));
            Console.WriteLine(soz.Substring(17, 4));
            string userName = " Mehmet";
            Console.WriteLine(userName.Trim());


            #endregion

            #region MyRegion
            string NameOrSurname = "Mehmet Teker";

            Console.WriteLine(NameOrSurname[2]);
            Console.WriteLine(NameOrSurname[NameOrSurname.Length - 5]);
            Console.WriteLine(NameOrSurname[2..^4]);

            #endregion
            int sayac = 0;

            foreach (var item in NameOrSurname)
            {
                if (item == 'e') sayac++;
                Console.WriteLine(item.GetType());
            }
            string[] adet = NameOrSurname.Split('e');
            string cumle = "sebebsiz yere yine çekip gideceksen güle güle sana";
            sayac = 0;
            while (true)
            {
                if (cumle.IndexOf(' ') == -1) break;
                sayac++;
                cumle = cumle.Substring(cumle.IndexOf(' ') + 1);
            }



            Console.WriteLine(numberName);
        }
    }

    class City
    {
        public string Name { get; set; }
    }
}
