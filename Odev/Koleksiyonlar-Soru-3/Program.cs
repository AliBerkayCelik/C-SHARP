namespace Soru3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        char[] sesliHarfler = SesliHarfler(cumle);
        Array.Sort(sesliHarfler);

        Console.WriteLine("Sesli Harfler:");
        foreach (char harf in sesliHarfler)
        {
            Console.WriteLine(harf);
        }
    }

    static char[] SesliHarfler(string cumle)
    {
        char[] sesliHarfler = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        List<char> bulunanHarfler = new List<char>();

        foreach (char harf in cumle.ToLower())
        {
            if (sesliHarfler.Contains(harf) && !bulunanHarfler.Contains(harf))
            {
                bulunanHarfler.Add(harf);
            }
        }

        return bulunanHarfler.ToArray();
    }

    
}
