using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Beyza Özdemir";
            musteri1.Id = "63727463";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "34678953";
            musteri2.AdSoyad = "Ayşenur Tekin";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "24543257";
            musteri3.AdSoyad = "Arda Özdemir";
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteriler);
            Console.WriteLine("--------------");
            
            musteriManager.Ekle(musteri3);
            Console.WriteLine("-------------");
            musteriManager.Sil(musteri2);
           


        }
    }
}
