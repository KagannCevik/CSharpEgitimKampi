using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mehthods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geri değer döndürmeyen methodlar
            //void listele()
            //{
            //    Console.WriteLine("Ahmet Yaşar");
            //    Console.WriteLine("Ahmet Veli");
            //    Console.WriteLine("Kağan Çevik");
            //    Console.WriteLine("Kağan Zeren");
            //}
            //listele();
            #endregion


            #region Geriye değer döndüren methotlar
            // string StudentsCard()
            // {
            //     string name = "Kağan";
            //     string surname = "Çevik";
            //     return name + " " + surname; 
            // }
            //Console.WriteLine(StudentsCard());
            #endregion

            #region Geriye değer dönüdren methodlar string parametreli 
            //string CountryCard(string CountryName,string capital,string flagColor)
            //{
            //    string countryInfo = "Ülke Adı: " + CountryName + "- Başkenti: " + capital + " -Bayrak Rengi: " + flagColor;
            //    return countryInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Başkentin adını giriniz: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak Rengini giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region Sınav Notları geriye değer döndüren method int
            string examresult(string studentsName, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 55)
                {
                    return studentsName+" Başarı ile geçti";
                }
                else
                {
                    return studentsName + " Başarısız";
                }
                
            }
            Console.WriteLine(examresult("Kağan", 70, 90, 100));
            Console.WriteLine(examresult("Ahmet", 70, 10, 90));


            #endregion


            Console.Read();

        }
    }
}
