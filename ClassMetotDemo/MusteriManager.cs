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
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            }
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Adi} {musteri.Soyadi} Eklendi.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Adi} {musteri.Soyadi} Silindi.");
        }
        
    }
}
