using System;

namespace TestProjectGozde
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, sonuc, cevap, dsayisi = 0, ysayisi = 0;
            Random rnd = new Random();

            for (int i = 1; i <= 10; i++)
            {
                s1 = rnd.Next(1, 10);
                s2 = rnd.Next(1, 10);
                sonuc = s1 * s2;
                Console.Write(s1 + "x" + s2 + "= ");
                cevap = Convert.ToInt32(Console.ReadLine());
                if (cevap == sonuc)
                {
                    Console.WriteLine("Cevap Doğru");
                    dsayisi++; //www.yazilimkodlama.com
                }
                else
                {
                    Console.WriteLine("Cevap Yanlış");
                    ysayisi++;
                }

            }  //www.yazilimkodlama.com
            Console.WriteLine();
            Console.WriteLine("Doğru Cevap Sayısı : {0}   -   Yanlış Cevap Sayısı : {1}", dsayisi, ysayisi);
            Console.ReadKey();
        }
    }
}
