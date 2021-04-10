using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        class Personel
        {
            public int ID { get; set; }
        }
        static void Main(string[] args)
        {
            #region ?(Nullable), ??(Null-Coalescing) , ??=(Nullable Coalescing Assigment), Default, is, is null, is not null, as
            /*
             * Not:                    : (int)*(double) = double, (byte)*(int) = int, byte * byte = int (istisna) :)
             * Default                 : Sayisal : 0, bool : false, string : null, char : \0, referans : null
             * is                      : Boxing'e tabi tutulmuş bir değerin öz türünü öğrenebilmek , kontrol etmek için kullanılan bir operatördür.
             *                           OOP yapılanmasında polimorfizm is operatörü ile kalıtımsal durumlardaki nesnelerin türlerinide öğrenebiliriz.
             * is null                 : nullable olan türleri kontrol etmek için kullanılır. (Referans türlü değişkenler.)    
             * as                      : Cast operatörünün UnBoxing işlemine alternatif olarak üretilmiş bir operatördür.
             *                           Türüne uygun bir şekilde as edilmesi zorunlu değildir. Eğer ki tür uygunsa unboxing islemi başarılı yapılacaktır, değilse null değer döndürecektir.
             *                           Cast operatörü ile yapacak olsaydık türüne uygun olmayanlar için hata verecek olurdu. Örn;  object x = 123; (string)x hata verirdi.
             *                           nullable olanlar ile çalışmaktadır geriye null dönderdiği için. Değer türlü değişkenler null alamaz çünkü.
             *?(Nullable)              : C# prog. dilinde değer tür. değişkenler normal şartlarda null değer alamazlar (not nullable). ? ile nullable yapılabilir. int? x;         
             *??(Nullable Coalescing)  : Elimizdeki değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlayan operatördür.
             *C#(8.0)                    Sol ve sağdaki değerler aynı türde olmalıdır.  string a=null;    a ?? "Mehmet"
             *                         
             *??=(Nullable Coalescing) :  null olan değişkenlerin değerine atama yapar ek olarak               
             *     Assigment
             *     
             *Ternary                  :Birden fazla Condition Uygulamak.  
             *                          string sonuc =  yas < 25 ? "A" : (yas == 25 ? "B" : "C")    
             */
            int a = default;
            int sayi = default(int); 
            string name = default; // null
            bool flag = default;
            char cinsiyet = default;
            Personel personel = new Personel();
            object o = personel;
            int? yas = null;

            Console.WriteLine("Sayi : " + sayi + " Flag :" +flag + " Cinsiyet :" + cinsiyet + " Personel :" + personel);
            Console.WriteLine("o :" + (o is Personel));

            object bulut = 123;

            Console.WriteLine(bulut as string);
            //Console.WriteLine((string)bulut);  // Unable to cast object of type 'System.Int32' to type 'System.String'.'

            string surname = null;
            Console.WriteLine(surname ?? "Null"); //   
            Console.WriteLine(surname == null ? "Null" : surname);
            Console.WriteLine(surname ??= "TEKER");
            Console.WriteLine(surname);

            string life = null;
            Console.WriteLine(life ??= "Aile");

            //  Ternary
            int number = 8;
            int result = number < 3 ? number * 5 : (number > 3 && number < 9 ? number * 3 : (number >= 9 && number % 2 == 0 ? number * 10 : ( number % 2 == 1 ? number : -9)));
            Console.WriteLine(result);
            #endregion


            Console.ReadLine();
        }
    }
 
}
