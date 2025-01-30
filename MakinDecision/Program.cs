using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İf Else Yapıları
            //Console.WriteLine("----Menü----");
            //Console.WriteLine("1.Tatlılar");
            //Console.WriteLine("2.İçecekler");
            //int number = 0;
            //Console.Write("Lütfen istediğiniz menünün başındaki sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 1)
            //{
            //    Console.WriteLine("Kazandibi");
            //    Console.WriteLine("Sütlaç");
            //    Console.WriteLine("Künefe");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("Gazoz");
            //    Console.WriteLine("Limonata");
            //    Console.WriteLine("Soda");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sayı girdiniz");
            //}


            //Console.Read();
            #endregion

            #region Switch Case Kullanımı 

            //Girilen Aya göre ayın hangi sayıya denk olduğunu bulan yapı 

            //int monthNumber;
            //Console.Write("Lütfen ay giriniz: ");
            //monthNumber= int.Parse(Console.ReadLine());
            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    default:Console.Write("Hatalı Giriş"); break;
            //}
            //Console.Read();
            #endregion

            #region 
            int number1, number2, result;
            char symbol;
            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz: ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write("İki Sayının Toplamı: "+result);
                    break;
                case '-': result=number1 - number2;
                    Console.Write("2 sayının farkı: " + result);
                    break;
                case '/': result = number1 / number2;
                    Console.Write("2 Sayının bölümü: " + result);
                    break;
                case '*': result = number1 * number2;
                    result= number1 * number2;
                    Console.Write("2 Sayının çarpımı: " + result);
                    break;
                default: Console.Write("Hatalı Sembol"); break;
            }


            Console.Read();
            #endregion

        }
    }
}
