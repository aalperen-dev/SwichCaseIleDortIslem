using System;

namespace SwichCaseIleDortIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aşağıdaki ekran çıktısı verilen soruyu switch-case yapısını kullanarak yapın.
            //Her aritmetik işlem, geriye değer döndüren parametreli metotlar ile yapılsın.
            //Programın sonunda 0’dan başka bir değer girilirse programda hiçbir şey yapılmasın.
            //Programa ait tüm metotları aşağıdaki boşluğa yazın.

            Menu();
        }
        static void Menu()
        {
            Console.Write("1. Sayıyı girin : ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı girin : ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplama için 1'e basın.");
            Console.WriteLine("Çıkarma için 2'ye basın.");
            Console.WriteLine("Çarpma için 3'e basın.");
            Console.WriteLine("Bölme için 4'e basın.");
            Console.WriteLine("Çıkış için 5'e basın.");
            Console.Write("Seçiminiz : ");
            int secim = int.Parse(Console.ReadLine());
            double sonuc = 0;
            switch (secim)
            {
                case 1:
                    sonuc = toplama(sayi1, sayi2);
                    break;
                case 2:
                    sonuc = cikarma(sayi1, sayi2);
                    break;
                case 3:
                    sonuc = carpma(sayi1, sayi2);
                    break;
                case 4:
                    sonuc = bolme(sayi1, sayi2);
                    break;
                case 5:
                    break;
            }

            Console.Write("İşlem sonucu : " + sonuc);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Devam etmek için 0'a basınız!");
            int devam = int.Parse(Console.ReadLine());
            if (devam == 0)
            {
                Console.Clear();
                //kod en bastan baslatıldıgında ekranı temızlıyoruz.
                //eger temizleme yapmayacaksak bu kod silinebilir.
                Menu();
            }
        }

        static int toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static int cikarma(int sayi1, int sayi2)
        {
            int cıkarım = sayi1 - sayi2;
            return cıkarım;
        }
        static int carpma(int sayi1, int sayi2)
        {
            int carpım = sayi1 * sayi2;
            return carpım;
        }
        static double bolme(int sayi1, int sayi2)
        {
            double bolum = (double)sayi1 / (double)sayi2;
            return bolum;
        }

    }
}

