using System;

namespace TestProjectGozde
{
    class Program
    {
        static void Main(string[] args)
        {
            //kodları hep buraya yazın static void main içine hata verir yoksa

            int sayi1, sayi2, sonuc = 0;

            Console.Write("1. Sayıyı girin:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı girin:");
            sayi2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < sayi2; i++)
            {
                sonuc += sayi1;
            }

            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, sonuc);
            Console.ReadLine();
        }
    }
}
