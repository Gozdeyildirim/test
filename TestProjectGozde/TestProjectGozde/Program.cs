using System;

namespace TestProjectGozde
{
    class Program
    {
        static void Main(string[] args)
        {
            //kodları hep buraya yazın static void main içine hata verir yoksa


            int mak = 0;
            int son = 0;
            Console.WriteLine("Cümleyi Girin :");
            Console.WriteLine("==========================================");
            String metin = Console.ReadLine();
            metin = metin.ToLower();
            String karakterler = "0123456789abcdefghijklmnopqrstuvwxyz.?,;";
            int[] count = new int[karakterler.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakterler[i] + " " + count[i]);
                }
            }

            //En fazla bulunan harf sayısı
            for (int i = 1; i < count.Length; i++)
            {
                if (mak < count[i])
                {
                    mak = count[i];
                    son = i; //Harf sayısı en fazla olan index numarası
                }

            }
            Console.WriteLine("En fazla olan karakter : " + karakterler[son] + ", sayısı " + mak);
            Console.ReadKey();



        }
    }
}
