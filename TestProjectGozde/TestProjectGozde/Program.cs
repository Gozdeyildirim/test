using System;

namespace TestProjectGozde
{
    class Program
    {
        static void Main(string[] args)
        {
            //kodları hep buraya yazın static void main içine hata verir yoksa


            int sayi;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi % 2 == 0) //sayinin 2 ile modunu hesaplıyoruz. mod 0 ise sayı çift olarak kabul edilir.
            {
                Console.Write(sayi + " sayisi çift sayıdır.");
            }
            else  //sayı sıfır değil de tek ise else kısmı çalışacaktır.
            {
                Console.Write(sayi + " sayisi tek sayıdır.");
            }
            Console.ReadKey(); //www.yazilimkodlama.com



        }
    }
}
