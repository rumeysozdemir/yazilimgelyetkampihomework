using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteriler Listelendi : " + musteri.Id + " : " + musteri.AdSoyad);
            }
        }


        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("ID Giriniz : ");
            musteri.Id = Console.ReadLine();
           
           
            Console.WriteLine("Müşteri Ad-Soyad Giriniz : ");
            musteri.AdSoyad = Console.ReadLine();

            Console.WriteLine("YENİ MÜŞTERİ VERİ TABANINA EKLENDİ" );

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " : " + musteri.AdSoyad + " ADLI MÜŞTERİ VERİ TABANINDAN SİLİNDİ");
        }
       
       
    }
}

