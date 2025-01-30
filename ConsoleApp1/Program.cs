using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            string name, surname;
            name = "Kağan";
            surname = "Çevik";
            Console.WriteLine(name+" "+surname);
            Console.WriteLine();
            Console.WriteLine("Menüler");
            Console.WriteLine("----------------");
            Console.WriteLine("Çorbalar");
            Console.WriteLine("İçecekler");
            int corbaprice = 50;
            int icecekprice = 20;
            int totolprice = 0;

            int corbaadet = 2;
            int icecekadet = 1;

           totolprice = corbaadet * corbaprice + icecekprice * icecekadet;
            Console.WriteLine("Toplam Fiyat" + totolprice + "Tl");


            Console.Read();




            #endregion




        }
    }
}
