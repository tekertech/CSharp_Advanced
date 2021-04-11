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
            #region İterasyon Nedir?, Dizi, ArrayList Koleksiyonlar, ArrayList ile Boxing - UnBoxing Durumları, List
            /*
             * Diziler ve Koleksiyonlar aynı amacı görmesine rağmen dizideki bazı eksiklikleri tamamlar koleksiyonlar.
             *   ---  Dizilerde tanımlama yaparken eleman sayısının bildirilmesi zorunluluğu bir sınırlılıktır.
             *   ---  Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen eleman sayısı kadar alan tahsis edilecektir.
             *   ---  Dizilerde eleman sayısının başta belirlenmesi durumunda, ihtiyaca binaen daha fazla değer atamak istediğimizde bu değerleri atayamacağımızdan ve dizinin
             *        aralığını genişletemeyeceğimizden dolayı bu durum bir sınırlılık olarak karşımıza çıkmaktadır. 
             * ArrayList :
             *       --  Verilen datayı boxing işlemine tabi tutar.
             *       --  İçerde herhangi bir datayı talep ettiğimizde o veri object olarak gelecektir. Dolayısıyla kendi türünde işlem yapabilmek için unboxing işlemine tabi tutmamız gerekir.
             * İterasyon  :
             *       --  Veri kümelerini incelerken döngülerde faydalanırız.
             *       İterasyon: Tekerrür, tekrarlama, yineleme ve mükerrer icrâ, ardışık işlem anlamlarına gelen iterasyon (iteration), programlamada bir dizi işlemin döngüler kullanarak yazılmasıdır. (Halk ağzıyla ittirmek :))
             *       foreach bu yapıda tercih edilir. 
             *İterasyon vs Döngü :
             *      Foreach(iterasyon) bir döngü değildir.  Tüm elemanlar bitene kadar devam eder. (bir mantık yoktur veya kombinasyon yoktur.)
             *      Döngüler : bir mantığa göre, kombinasyoma göre işlem yapar.
             */

            int[] ages = new int[17]; // Kaç eleman olacağını belirttik.
            ages[1] = 14;


            ArrayList _ages = new ArrayList(); // Eleman sayısını belirtmedik.
            _ages.Add(14);
            _ages.Add("Mehmet");
            _ages.Add(25);
            _ages.Add(0.25);
            _ages.Add(true);
            _ages.Add('F');

            int toplam = 0;
            foreach (var item in _ages)
            {
                // Boxing - UnBoxing
                //  _ages.Add(object value)   object olarak içeri alır biz int,string versekte

                if (item is int number) {  //  Type Pattern işlemi ile int olanları aldık.
                    toplam += number;
                }
                Console.WriteLine("Items :" + item);
            }

             // Tip alıp eklemek.            
            List<int> vs = new List<int>()
            {
                14,25,36,87
            };

            #endregion

            



            Console.ReadLine();
        }

    }
 
}
