using System;

namespace TestProjectGozde
{
    class Program
    {
        static void Main(string[] args)
        {
            //kodları hep buraya yazın static void main içine hata verir yoksa

            string metin;
            Console.Write("Metni Girin  : ");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            Console.ReadKey();

        }
    }
}
