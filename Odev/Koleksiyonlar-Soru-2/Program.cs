using System.Collections;

namespace Soru2;
class Program
{
    static void Main(string[] args)
    {
        ArrayList sayilar = new ArrayList();

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out int girilenSayi) && girilenSayi >= 0)
            {
                sayilar.Add(girilenSayi);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir pozitif sayı girin.");
                i--;
            }
        }

        sayilar.Sort();

        ArrayList enBuyukUcSayi = new ArrayList(sayilar.GetRange(sayilar.Count - 3, 3));
        ArrayList enKucukUcSayi = new ArrayList(sayilar.GetRange(0, 3));

        Console.WriteLine("En Büyük 3 Sayı:");
        foreach (int sayi in enBuyukUcSayi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine();

        Console.WriteLine("En Küçük 3 Sayı:");
        foreach (int sayi in enKucukUcSayi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine();

        double enBuyukOrtalama = Ortalama(enBuyukUcSayi);
        double enKucukOrtalama = Ortalama(enKucukUcSayi);

        Console.WriteLine("En Büyük 3 Sayıların Ortalaması: " + enBuyukOrtalama);
        Console.WriteLine("En Küçük 3 Sayıların Ortalaması: " + enKucukOrtalama);
        Console.WriteLine("Ortalama Toplam: " + (enBuyukOrtalama + enKucukOrtalama));
    }

    static double Ortalama(ArrayList list)
    {
        int Toplam = 0;
        foreach (int item in list)
        {
            Toplam += item;
        }
        return (double)Toplam / list.Count;
    }
}
