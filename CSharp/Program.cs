using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Type Conversion, Explicit Type Conversion , checked, unchecked
            /*
             * Metinsel ifadeleri diğer ifadelere dönüştürmek için 2 yöntem kullanılır. Parse, Convert
             * Tür dönüşümlerinde amaç turu donusturmektir. Yani elimizdeki veriye uygun bir türe geçiş yapmaktır.
             * Diğer ifadeleri metinsel ifadelere dönüştürmede : Convert ve ToString()  kullanılabilir.
             * Sayısal türler kendi aralarında tür dönüşümü gerçekleştiriken max değerlerine dikkat etmek lazım. implicit, explicit olayları devreye girecektir.
             * int a = 65999;   byte b = a; yaparsak arka tarafta  a % 256 işlemine tabi olacak ve b == 207 olacaktr. değer kaybı oldu.
             * Implicit Type Conversion, Explicit Type Conversion , 
             * Normal bir kod bloğu unchecked dir.
             * 2 Özel tür dönüşümü vardır : bool -> Sayısal ,   char -> sayısal (ASCII)
             */
            #endregion

            string degisken = "123";
            int parseInt = int.Parse(degisken);
            parseInt = Convert.ToInt32(degisken);

            byte a = default;
            int b = 65999;
            short c = 32767;

            a = (byte)b;
            c = (short)b;

            string e = c.ToString();


            int a1 = 3000;
            short b1 = (byte)a1;  // (byte)a1 : Explicit Type Conversion (Bilinçli Tür Dönüşümü (Açık)),  short b1 = (byte)a1 : Explicit Type Conversion (Bilinçsiz Tür Dönüşümü(Kapalı))


            unchecked   // kullanmazsakta olur çünkü default olarak c# da kod blokları unchecked dir.
            {
                int a2 = 3000;
                short b2 = (byte)a2;
            }

            checked   // System.OverflowException: 'Arithmetic operation resulted in an overflow.'   Değer kaybı olduğunda hata  verir.
            {
                int a2 = 3000;
                short b2 = (byte)a2;
            }


            bool a4 = true;
            int b4 = Convert.ToInt32(a4);

            Console.WriteLine(a);

            Console.ReadLine();
        }
         
    }
 
}
