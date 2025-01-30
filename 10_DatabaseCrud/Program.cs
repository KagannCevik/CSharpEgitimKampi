using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Catagory Name ekleme
            //Console.WriteLine("Eklemek İstediğiniz Kategori adını giriniz");
            //string categoryName;
            //categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CatogoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ekleme İşlemi Başarıyla Gerçekleşti");



            #endregion

            Console.WriteLine("***** Menü Sipariş Ekleme Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------");

            #region Product Ürün Ekleme

            ////string productName;
            ////decimal productPrice;
            ////bool productStatus;

            ////Console.WriteLine("Lütfen eklemek istediğiniz ürün adını girin");
            ////productName=Console.ReadLine();
            ////Console.WriteLine("Eklemek istediğiniz ürünün fiyatını girin");
            ////productPrice=int.Parse(Console.ReadLine());
            ////Console.WriteLine("Durumu belirtin");
            ////productStatus=bool.Parse(Console.ReadLine());

            ////SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            ////connection.Open();
            ////SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection);
            ////command.Parameters.AddWithValue("@p1",productName);
            ////command.Parameters.AddWithValue("@p2",productPrice);
            ////command.Parameters.AddWithValue("@p3",productStatus);
            ////command.ExecuteNonQuery();
            ////Console.WriteLine("Ekleme İşlemi Başarılı");




            #endregion

            #region Delete işlemi 
            //Console.WriteLine("Silmek istedğiniz ürünün id numarasını girin");
            //int productId=int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi başarılı");


            #endregion

            #region Update İşlemi
            // Kullanıcıdan veri alma 
            Console.WriteLine("Güncellemek istedğiniz id numarasını seçin");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ürün adını girin");
            string productName = Console.ReadLine();
            Console.WriteLine("Ürün Fiyatını Giriniz");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Durumunu seçiniz");
            bool productStatus = bool.Parse(Console.ReadLine());

            //sql update 

            SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName,ProductPrice=@productPrice,ProductStatus=@productStatus where ProductId=@productId",connection);


            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", productStatus);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme İşlemi Başarılı");



            #endregion

            Console.Read();
        }
    }
}
