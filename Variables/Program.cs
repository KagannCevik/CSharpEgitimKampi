using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişkenler 
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            patatoPrice = 9.74;
            tomatoPrice = 6.88;
            Console.WriteLine("****Fiyat Listesi*****");
            Console.WriteLine("---Elma Birim Fiyatı" + " " + applePrice + "₺");
            Console.WriteLine("---Portakal Birim Fiyatı" + " " + orangePrice + "₺");
            Console.WriteLine("---Çilek Birim Fiyatı" + " " + strawberryPrice + "₺");
            Console.WriteLine("---Patates Birim Fiyatı" + " " + patatoPrice + "₺");
            Console.WriteLine("---Domates Birim Fiyatı" + " " + tomatoPrice + "₺");

            double applegram, orangegram, strawberrygram, patatogram, tomatogram;
            applegram = 1.245;
            orangegram = 2.650;
            strawberrygram = 0.750;
            patatogram = 4.859;
            tomatogram = 3.745;

            double appleTotalPrice, orangeTotalPrice, strawTotalPrice, patatoTotalPrice, TomatoTotalPrice;
            appleTotalPrice = applegram * applePrice;
            orangeTotalPrice = orangegram * orangePrice;
            strawTotalPrice = strawberrygram * strawberryPrice;
            patatoTotalPrice = patatogram * patatoPrice;
            TomatoTotalPrice = tomatogram * tomatoPrice;
            Console.WriteLine();
            Console.WriteLine();
            double shoppingTotalPrice;
            shoppingTotalPrice = appleTotalPrice + orangeTotalPrice +
               strawTotalPrice + TomatoTotalPrice + patatoTotalPrice;

            Console.WriteLine("Alınan Ürün:" + " " + "Elma -" + "Birim Fiyat:" + " " + applePrice + " " + "Gramaj:" + " " + applegram + " " + "Toplam Tutar" + " " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün:" + " " + "Portakal -" + "Birim Fiyat:" + " " + orangePrice + " " + "Gramaj:" + " " + orangegram + " " + "Toplam Tutar" + " " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün:" + " " + "Çilek -" + "Birim Fiyat:" + " " + strawberryPrice + " " + "Gramaj:" + " " + strawberrygram + " " + "Toplam Tutar" + " " + strawTotalPrice);
            Console.WriteLine("Alınan Ürün:" + " " + "Domates -" + "Birim Fiyat:" + " " + tomatoPrice + " " + "Gramaj:" + " " + tomatogram + " " + "Toplam Tutar" + " " + TomatoTotalPrice);
            Console.WriteLine("Alınan Ürün:" + " " + "Patetes -" + "Birim Fiyat:" + " " + patatoPrice + " " + "Gramaj:" + " " + patatogram + " " + "Toplam Tutar" + " " + patatoTotalPrice);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Toplam Alışveriş Tutarı:" + " " + shoppingTotalPrice + "₺");


            #endregion

            #region String Değişkenler 
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge;
            //Console.Write("Yolcu Adı :");
            //passengerName=Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname =Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcu İlçe ");
            //passengerDistrict = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcu Şehir");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcu Yaşı");
            //passengerAge= Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Adı: "+passengerName+" "+ "Yolcu Soyad: "
            //    +passengerSurname+" "+"Yolcu İlçe: "+passengerDistrict+" "
            //    +"Yolcu Şehir: "+passengerCity+" "+"Yolcu Yaşı: "+passengerAge);




            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler 
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı miktarını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar miktarını giriniz:  ");
            //computerCount=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye miktarını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen adlığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int totolPrice;
            //totolPrice = shoePrice * shoeCount + computerPrice * computerCount + chairPrice * chairCount +
            //tvPrice * tvCount;
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+ totolPrice);







            #endregion

            #region Klavyeden Girilen Double Değerler 
            //double exam1, exam2, exam3;
            //Console.Write("Lüften 1. Sınav Notunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lüften 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lüften 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //double result = (exam1+exam2+exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);



            #endregion

            #region Char Dönüştürme
            //char gender;
            //Console.Write("Lüften Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            #endregion

            Console.Read();

        }
    }
}
