using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
              Id = 1,
              Adi = "Ali",
              Soyadi = "KARA"
            };
            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Adi = "Ahmet",
                Soyadi = "KARA"
            };
            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                Adi = "Arif",
                Soyadi = "KARA"
            };

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);

            musteriManager.Ekle(musteri1);

            musteriManager.Sil(musteri3);

            Console.ReadLine();

        }
    }
}
