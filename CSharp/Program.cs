using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C# Pattern Matching
            #region Type Pattern
            /*
             * C# 7.0 ile gelmiş 9.0 ile daha güçlenmiştir.
             * Object içerisindeki bir tipin belirlenmesinde kullanılan is operatörünün desenleştirilmiş halidir.
             * is ile belirlenen türün direkt dönüşümünü sağlar. As ve Cast işlemine gerek kalmaz.
             * Kritik : Scope olarak if in içerisinde bulunduğu scope içeriisnde ilgili değişken kullanılabilir. Fakat Use of unassigned local variable 'a'   dikkat edilmeli.
             */

            object name = "Mehmet";

            if (name is string a) // a ile dönüştürüp geri döndürür.
            {
                // string a_ = name as string;  bunu yazmaya gerek yok
                Console.WriteLine("Name : " + a.ToString());
            }
            else if (name is int b) 
            {
                int xx = (int)name; //  gerek kalmayacak
            }

            //Console.WriteLine("Scope Dışı : " + a);  // Use of unassigned local variable 'a'   !!!!!!!!!!  KRİTİK 
            #endregion
            #region Constant Pattern
            /*
             * == operatörünün işlemini gerçekleştirir
             * is operatörü bir değğişkenin türünü sormamızı/belirlemizi saağlayan bir operatördür ve bu operatörün kullanıldığı değişkenlerin türü illa bir referans türlü olma zorunluluğu yoktur.
             * İsterseniz değer türlü değişkenleri de is operatörü ile kullanılabilir hatta primitive türlerde bile kullanılabilmektedir.
             */
            object number = 45;
            if (number is 45) { 
                Console.WriteLine("Değer Kontrolu : " + number);
            }
            if (number is int) { // Normal is operatörün işlemi kullanılmıştır.
                Console.WriteLine("INT");
            }

            int salary = 5; // is operatörün işlemidir aşağıdaki işlemler Constant ın değil. Kritik
            Console.WriteLine(salary is int); // primitive
            Console.WriteLine(salary is string); // referans
            Console.WriteLine(salary is bool); // değer



            #endregion
            #region Var Pattern   
            /*
             * Eldeki veriyi 'var' değişkeni ile elde etmememizi sağlar
             * Var : verilen değerin türüne bürünen bir keyword... runtime'da bürünme işlemini gerçekleştirmektedir.
             * Kritik : Normalde var derleme anında türüne bürünür ama Var Pattern deki var runtime da türüne bürünür dynamic gibi.
             */
            object surname = "Teker";  //
            var ogrenci = true;
            dynamic mudur = 12; //  runtime da türünü belirtir.

            if(surname is var newType)
            {
                Console.WriteLine(newType.GetType());
            }
            #endregion
            #region Recursive Pattern
            /*
             * Bu desen switch-case yapılanması üzerinde birçok yenilik getirmektedir.
             * Switch bloğunda referans türlü değişkenlerde kontrol edilebilmektedir. Recursive Pattern ile geldi !1!!!!!!
             * Ayrıca switch bloğunda when komutu ile çeşitli şat/koşul niteliği kazandırılmıştır. Recursive Pattern ile geldi !!!!!!!!!
             * Tür kontrolu yapıldığı için Typoe Pattern kapsamaktadır.
             * case null komutu ile ilgili türün/referansın null olup olmamasını kontrol edebilmesinden dolayı Constant Pattern ı da kapsamaktadır.
             */
            SqlConnection sqlConnection = new SqlConnection("");
            var connecton =  CompareToConnection(sqlConnection);
            SqlConnection sqlConnectionNull = null;
            dynamic connectonDynamic = CompareToConnection(sqlConnectionNull);

            #endregion
            #region Type vs Var Pattern Kritik
            object o = "Vanadokya";

            bool result = o is string city;        
            //Console.WriteLine("Şehir : " + city); //  Type Pattern da Use of unassigned local variable 'a'   hatası alır.
            result = o is var city1;
            Console.WriteLine("Şehir :" + city1);  // Var Pattern de hata almaz run-time da ne tür gelirse ona bürünür.
            #endregion

            #region MyRegion

            #endregion
            #endregion

            Console.ReadLine();
        }

        static ICloneable CompareToConnection(ICloneable cloneable) 
        {
            switch (cloneable)
            {
                case SqlConnection sqlConnection:
                    sqlConnection.ConnectionString = "Server=(localdb)\v11.0;Integrated Security=true";
                    return sqlConnection;
                case SqlCommand sqlCommand when sqlCommand.Connection.ConnectionString != null:
                     sqlCommand.CommandText = "Select * From Table";
                    return sqlCommand;
                case null:
                    return cloneable;
                default:
                    return cloneable;
            }
        }
    }
 
}
