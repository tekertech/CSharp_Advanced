using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CSharp
{

    class Person 
    {
        public int Id { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * *******************************************************************************************************************************************
             * Tuple             : Tek bir syntax üzerinde birden fazla değişken tanımlamamızı sağlayan bir nesnedir.                                    *
             *                     int x = 5;                                                                                                            *
             *                     (bool a, char b, byte c, short d, int e, long f, float h, double j, decimal k)Z;   Tuple değişken Z :)                *
             *                     (int a, string b)c = (5, "Ahmet")  sıralı olarak atama yapılır.                                                       *
             *                     c.a --->  5,   c.b ---> Ahmet   erişim                                                                                *
             *                                                                                                                                           *
             *********************************************************************************************************************************************
             *                                                                                                                                           *
             * Değişkenler arası değer atanırken verisel açıdan iki davranış söz konusudur.   Deep Copy, Shallow Copy                                    *
             * Deep Copy         : Derin kopyalama neticesinde eldeki veri çoğalır/klonlanır.                                                            *
             *                     int a = 5;   b = a;                                                                                                   *
             *                     Değer türlü değişkenler birbirine atanırken default olarak deep copy geçerlidir. Yani veri otomatik olarak türetilir. *
             *                     (bool, char, byte,short,int,long,float,double,decimal)                                                                *
             *                                                                                                                                           *
             * *******************************************************************************************************************************************
             * Shallow Copy     : Değişkenler arası değer atamalarında değeri türetmek/çoğaltmak/klonlamak yerine var olanı birden fazla referansla işaretlemeye
             *                    dayalı kopyalama yöntemidir.
             *                    Bellekte birden fazla referansın tek bir veriyi işaret etmesidir.
             *                    Neticede ilgili değer bir değişikliğe uğradığında tüm işaretleyen referanslara bu değişiklik yansıyacaktır.
             * 
             * 
             */

            int age = default;
            string name = default;
            char gender = default;
            string job = default;

            (int age, string name, char gender, string job) kisi = (age,name,gender,job);
            kisi.name = "";
            
            Tuple<int, string, char, string> person = new Tuple<int, string, char, string>(age, name, gender, job);
            person = (14, "Test",'E', "C").ToTuple<int,string,char,string>();

            Person person1 = new Person { Id = 1 };

            Person person2 = person1;
            person2.Id = 2;

            Console.WriteLine(person1.Id);

            GetJob(person);
            Console.ReadLine();
        }

        public static string GetJob(Tuple<int,string,char,string> tuple) {

            if(tuple.Item1 > 10)
            {
                return "Deneme";
                 
            }
            return "Engineer";
        }

    }
 
}
