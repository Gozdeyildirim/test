using System;

namespace TestProjectGozde
{
    class Program
    {
        static void Main(string[] args)
        {
            //kodları hep buraya yazın static void main içine hata verir yoksa


            string metin = "Merhaba Dünya! +123";
            Console.WriteLine(metin + "\n");
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           + "abcçdefgğhiıjklmnoöprsştuüvyz";

            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                //karakter karakter kontrol ediyoruz.
                if (liste.Contains(metin[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane  harf vardır.", sayac);
            Console.ReadLine();



        }
    }
}
