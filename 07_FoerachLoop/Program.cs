using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FoerachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach toplama
            //int total = 0;
            //int[] numbers = { 1, 2, 3, 4, 5, };
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            #endregion

            #region kelime harf harf yazdırma 
            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Öğrenci Sınav Notu Uygulaması       

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var");
            int studuentcounts=int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");

            string[] studenstnames = new string[studuentcounts];
            double[] studentsexamavg = new double[studuentcounts];

            for (int i = 0; i < studuentcounts; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
                studenstnames[i] = Console.ReadLine();
                double totalexamresult = 0;
                
                for(int j =0;j<=2; j++)
                {
                    Console.Write($"{studenstnames[i]} İsimli Öğrencinin {j+1} Sınav Notu: ");
                    double value =double.Parse(Console.ReadLine());
                    totalexamresult+= value;
                }
                Console.WriteLine();
                studentsexamavg[i] = totalexamresult/3;
                
            }
            //Sınav Ortalamaları
            for(int i = 0;i < studuentcounts; i++)
            {
                Console.WriteLine($"{studenstnames[i]} adlı öğrencinin ortalaması: {studentsexamavg[0]}");
                if (studentsexamavg[i] >= 55)
                {
                    
                }
                else
                {
                    Console.WriteLine($"{studenstnames[i]} ÖĞRENCİ Geçti");
                }
            }

            #endregion


            Console.Read();
        }
    }
}
