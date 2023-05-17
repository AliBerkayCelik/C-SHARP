namespace Diziler;
class Program
{
    static void Main(string[] args)
    {
        //Dizi Tanımlama
        string[] renkler=new string[5];
        string[] hayvanlar={"Kedi","Köpek","Kuş","Maymun"};
        int[] dizi;
        dizi=new int[5];
        // Dizilere değer atama ve erişim

        renkler[0]="Mavi";
        dizi[3]=10;
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(renkler[0]);
        Console.WriteLine(dizi[3]);

        //Döngülerle dizi kullanımı
        //Klavyeden girilen n tane sayının ortalamasını hesaplayan program.
        Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
        int diziUzunluğu=int.Parse(Console.ReadLine());
        int[] sayiDizisi= new int[diziUzunluğu];
        for(int i=0;i<diziUzunluğu;i++)
        {
            Console.WriteLine("Lütfen {0}. sayıyı giriniz: ",i+1);
            sayiDizisi[i]=int.Parse(Console.ReadLine());
        }

        int toplam=0;
        foreach(var sayi in sayiDizisi)
        {
            toplam+=sayi;
        }
        Console.WriteLine("Ortalama: "+ toplam/diziUzunluğu);


    }
}
