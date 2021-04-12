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
            #region RAM(STACK/HEAP);  Value Type(IsValueType) - Primitive Type (IsPrimitive), Literal Düzenleme(Alt tire (_) C# 7.0), Default Literal C# 7.1
            /*
             * C# programlama dilinde RAM de veri tutabilmek depolayabilmek için tanımlanacak olan değişkenin türü/veri türü bildirilmelidir.
             * Bir değişkenle RAM'de alan tahsisinde bulunulduğunda buna Deger türlü değişken diyoruz. Yani tuttuğu deger bir normal deger olan değişkenlere deger türlü denmektedir.
             * Değer Türlü değişkenler sade ve sadece br değeri tutan değişkenlerdir. Yani adınız soyadınız yaşınız gibi.
             * Primitive Type : En ilkel türdür; byte bir primitive türdür fakat decimal primitive değildir çünkü byte lardan meydana gelmiştir. ikiside value type dir.
             * Value Type , Primitive Type leri kapsar.
             * Değişken tanımlarken RAM'de tutulacak veriye uygun bir alan tahsisinde bulunabilmek için ilgili değişkenin turunden hareket edilir.
             * RAM de bir türden tanımlanmış alana farklı bir türde deger atayamayız.
             * 
             * * ***********************************************************************************************************************TIP*********************
             * *Tür*******Açıklama ve Bellek Alanı***************Max-Min aralığı                                                                               *
             * *************************************************************************************************************************TIP*********************
             * MANTIKSAL  * bool     *  Doğru veya yanlış (1 Bit)      *        0-1 (True- False)                                                 * MANTIKSAL  *
             * METINSEL   * char     *  Karakterler(16 Bit)            *        16 Bit Unicode                                                    * METINSEL   *
             * SAYISAL    * sbyte    *  İşaretli Tam Sayı(8 Bit)       *       -128 ile 127 arası                                                 * SAYISAL    *
             * SAYISAL    * byte     *  İşaretsiz Tam Sayı(8 Bit)      *        0 ile 255 arası                                                   * SAYISAL    *
             * SAYISAL    * short    *  İşaretli Tam Sayı(16 Bit)      *        -32.768 ile 32.767                                                * SAYISAL    *
             * SAYISAL    * ushort   *  İşaretsiz Tam Sayı(16 Bit)     *        0 ile 65.535                                                      * SAYISAL    *
             * SAYISAL    * int      *  İşaretli Tam Sayı(32 Bit)      *        -2.147.483.468 ile 2.147.483.647 arası                            * SAYISAL    *
             * SAYISAL    * uint     *  İşaretsiz Tam Sayı(32 Bit)     *        0 ile 4.294.967.295 arası                                         * SAYISAL    *
             * SAYISAL    * long     *  İşaretli Tam Sayı(64 Bit)      *        -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.808 arası    * SAYISAL    *
             * SAYISAL    * ulong    *  İşaretsiz Tam Sayı(64 Bit)     *         0 ile 18.446.744.073.709.551.615 arası                           * SAYISAL    *
             * ONDALIK    * float    *  Tek kayan Sayı(32 Bit)         *                                                                          * ONDALIK    *
             * ONDALIK    * double   *  Çift Kayan Sayı (64 Bit)       *                                                                          * ONDALIK    *
             * ONDALIK    * decimal  *  Ondalık Sayı(128 Bit)          *                                                                          * ONDALIK    *
             * ***************************************************************************************************************************TIP*******************
             *  Değişkenler RAM ın STACK bölgesinde tutulur. 
             *  Kompleks sayısal ifadeleri _ (Alt tire) ile düzenlememizi sağlayan özelliktir. 10000000000 ->   10_000_000_000
             *  Default Literal :  default keyword ü ile türün varsayılan değerini geri döndürür.
             *                  string : null           bool : false
             *                  sayisal: 0              char : ''
             *                  Double : 0              byte : 0
             *  Main içerisinde oluşturulan değişkenlerin ilk değerlerini manuel atmaya özen gösteriniz. Class larda default verilir otomatik olarak.
             *  Default Literal C# 7.1 int x = default;
             */
            #endregion
            Console.WriteLine("IsPrimitive : " + typeof(decimal).IsPrimitive + " IsValueType : " + typeof(decimal).IsValueType);
            Console.WriteLine("IsPrimitive :" + typeof(byte).IsPrimitive + " IsValueType : " + typeof(byte).IsValueType);
            Console.WriteLine("IsPrimitive :" + typeof(string).IsPrimitive + " IsValueType : " + typeof(string).IsValueType);

            //  Değişkenler RAM ın STACK bölgesinde tutulur. Run-Time'da alan tahsisinde bulunur.
            int yas;
            string name;

            // Literal Düzenleme (C# 7.0)
            int number = 1_000_000;

            Console.WriteLine("Number : " + number);
            Console.WriteLine(default(bool) + " " + default(char) + " " + default(byte));
            Console.WriteLine(default(short) + " " + default(int) + " " + default(long));
            Console.WriteLine(default(float) + " " + default(double) + " "+ default(decimal));
            Console.WriteLine(default(string) + " " + default(object));

            Console.ReadLine();
        }

    }
 
}
