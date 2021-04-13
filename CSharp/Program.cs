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
            #region Manevratik Komutlar: Break, Continue, Return
            /*
             * Break    Komutu: 2 yerde kullanılır. Switch Case ve Döngüler'de
             * Continue Komutu: Sade ve sadece döngülerden erişilebilen ve döngülerde kullanılabilen bir keyworddur.    
             *                  Döngüde bir sonraki tura geçmemizi sağlar.
             * Return   Komutu: Her yerde(metot içerisinde) kullanılabilir, erişilebilir bir keyword dur.
             *                  2 işlemi gerçekleştirir. Metottan çıkma ve değer döndürme.
             * Goto     Komutu: Kodun senkranizasyonunu bozup, askisi ters istikamette almamızı sağlayan bir manevratik komuttur.
             *                  switch case yapılanmasında dahili olarak kullanılan bu komut, metot içeriisinde heryerde kullanılabilir.
             */
            #endregion
            int a = 0;

            switch (10)
            {
                case 2:
                    Console.WriteLine("2");
                    break;
                case 10:
                    Console.WriteLine("10 değeri mevcut.");

                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            int sayac = 0;
            while (true)
            {
                if (sayac == 100) break;
                sayac += 1;
            }

            do
            {
                if (sayac == 0) break;
                 
                sayac -= 1;

            } while (true);

            int toplam = default;

            for (int i = default; i < 100; i++)
            {
                if (i % 10 != 0) continue;

                toplam += i;
                if (i == 50) break;
            }

            //GetName();

            // Goto Kulllanımı


            switch (10)
            {
                case 10:
                    if (1 == 1)
                        goto case 5;
                    break;
                case 5:
                    Console.WriteLine("Goto yönlnedirdi.");
                    break;
                default:
                    break;
            }


            Console.ReadLine();
        }


        static void GetName() {
            long sayac = 1_000_000;
            for (int i = 0; i < 100; i++)
            {
                switch (i)
                {
                    case 50:
                        while (true)
                        {
                            sayac += 1000;
                            if (sayac > 1_000_000);
                        }
                    default:
                        break;
                }
            }
        }
    }
 
}
