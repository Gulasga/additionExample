using System;

namespace additionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string cevap;
            int puan = 0;
            do {
                Random rastgele = new Random();
                int x = rastgele.Next(1, 100);
                int y = rastgele.Next(1, 100);
                Console.WriteLine(x);
                Console.WriteLine(y);

                int toplam = x + y;
                
                Console.WriteLine("Bu iki sayının toplamı nedir ?");
                int tahmin;
                tahmin = Int32.Parse(Console.ReadLine());


                if (toplam == tahmin)
                {
                    Console.WriteLine("Tebrikler bildiniz");
                    puan += 5;
                }
                else
                {
                    Console.WriteLine("Üzgünüm bilemediniz");
                    puan -= 2;
                }

            


            Console.WriteLine("Devam etmek istiyor musunuz ?");
            cevap = Console.ReadLine();
            } while (cevap=="e" || cevap == "E");
            if(cevap!="e" ||cevap != "E")
            {
                Console.WriteLine("Oyundan çıkılıyor.. ");
                Console.WriteLine("Puanınız : " + puan);
            }

            Console.ReadLine();

           
        }
    }
}
