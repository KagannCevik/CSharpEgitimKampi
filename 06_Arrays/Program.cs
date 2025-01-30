using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region dizilerde tanımlama 
            //string[] colors = new string[4];
            //colors[0] = "Beyaz";
            //colors[1] = "Mavi";
            //colors[2] = "Mor";
            //colors[3] = "Kırmızı";

            //Console.WriteLine(colors[0]);

            #endregion

            #region Kolay Kullanım 
            //string[] cities = { "Samsun", "Adana", "Kars" };
            //Console.WriteLine(cities[0]);
            #endregion

            #region Dizideki tüm elemanları for döngüsüyle yazdırma 
            //string[] colors = { "pempe", "mor", "beyaz", "kırmızı" };
            //for (int i = 0; i< colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            #endregion

            #region Kullanıcıdan Veri Alma

            //string[] cities = new string[4];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine("Lüften dizinin "+i+": "+"Elemanını giriniz");
            //    cities[i] = Console.ReadLine();
            //}
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            #endregion

            #region tek ve çift sayılar birlikte listeleme
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    
                    Console.Write(numbers[i]);
                }
               
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {

                    Console.Write(numbers[i]);
                }

            }
            #endregion
            Console.Read();
        }
    }
}
