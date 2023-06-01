using System.Collections;

namespace Soru1;
class Program
{
    static void Main(string[] args)
    {
        ArrayList asalListesi = new ArrayList();
        ArrayList asalOlmayanListesi = new ArrayList();

        int girilenSayi;
        int sayac = 0;

        while (sayac < 20)
        {
            Console.Write("Bir pozitif sayı girin: ");
            string sayi = Console.ReadLine();

            if (int.TryParse(sayi, out girilenSayi) && girilenSayi > 0)
            {
                if (Asal(girilenSayi))
                {
                    asalListesi.Add(girilenSayi);
                }
                else
                {
                    asalOlmayanListesi.Add(girilenSayi);
                }

                sayac++;
            }
            else
            {
                Console.WriteLine("Lütfen pozitif bir sayı girin.");
            }
        }

        Console.WriteLine("Asal Sayılar:");
        asalListesi.Sort();
        asalListesi.Reverse();
        foreach (int item in asalListesi)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Console.WriteLine("Asal Olmayan Sayılar:");
        asalOlmayanListesi.Sort();
        asalOlmayanListesi.Reverse();
        foreach (int item in asalOlmayanListesi)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Console.WriteLine("Asal Sayıların Eleman Sayısı: " + asalListesi.Count);
        Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı: " + asalOlmayanListesi.Count);

        double asalOrtalama = ortlama(asalListesi);
        double asalOlmayanOrtalama = ortlama(asalOlmayanListesi);

        Console.WriteLine("Asal Sayıların Ortalaması: " + asalOrtalama);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + asalOlmayanOrtalama);
    }

    static bool Asal(int sayi)
    {
        if (sayi < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static double ortlama(ArrayList liste)
    {
        if (liste.Count == 0)
        {
            return 0;
        }

        int toplam = 0;

        foreach (int sayi in liste)
        {
            toplam += sayi;
        }

        return (double)toplam / liste.Count;
    }
}
