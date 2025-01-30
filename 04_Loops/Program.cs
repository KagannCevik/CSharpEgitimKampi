using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü 
            //1 ile 50 arasında 7 sayısına bölünen kaç tane sayı vardır ? 

            //int count = 0;
            //for (int i=1; i<=50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count += 1;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine();    
            //Console.WriteLine(count);


            //Console.Read();
            #endregion

            #region 1 ile 20 arasındaki çift saytıların toplamı 
            //int totatvalue = 0;
            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i%2==0)
            //    {
            //        totatvalue += i;
            //        Console.WriteLine(i);
            //    }             
            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam" +" "+ totatvalue);
            #endregion

            #region Bakteri Sorusu
            //int bacterium = 1;
            //for (int i = 1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+".Saatin sonunda"+" "+bacterium);
            //}
            #endregion

            #region While Döngüsü
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            #endregion

            #region 3 basamaklı bir sayının basamakları toplamı 
            int ones, tens, hundreds;
            int sum;
            Console.WriteLine("Lüften Sayıyı giriniz");
            int number=int.Parse(Console.ReadLine());

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = (number / 100);
            Console.WriteLine(hundreds + "-" + tens + "-" + ones);
            sum = ones + tens + hundreds;
            Console.WriteLine("Toplamı: "+sum);

            #endregion


            Console.Read();
        }
    }
}
