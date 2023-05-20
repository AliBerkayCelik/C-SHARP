namespace CalismaSorulari;
class Program
{
    static void Main(string[] args)
    {
        //1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
    
           Console.WriteLine("Kaç adet pozitif sayı girilecek: ");
           int gir=int.Parse(Console.ReadLine());
           int[] dizi=new int [gir];
           if(gir<0 && gir==null)
           {
            
                Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            
           }
           else
           {
            
                for(int i=0;i<dizi.Length;i++)
                {
                    Console.Write((i+1)+". Sayıyı giriniz: ");
                    dizi[i]=int.Parse(Console.ReadLine());
                
                
                }
                for(int i=0;i<dizi.Length;i++)
                {
                    if(dizi[i]%2==0)
                    {
                        Console.Write(dizi[i]+" ");
                    }
                }
            }


        //2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        Console.Write("Lütfen birinci pozitif sayıyı girin: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Lütfen ikinci pozitif sayıyı girin: ");
        int m = int.Parse(Console.ReadLine());

        int[] sayilar = new int[n];
        int[] bolunebilienSayilar = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write((i+1)+". Sayıyı giriniz: ");
            sayilar[i] = int.Parse(Console.ReadLine());

            if (sayilar[i] % m == 0)
            {
                bolunebilienSayilar[i] = sayilar[i];
            }
        }

        Console.WriteLine(m+" 'a eşit veya tam bölünen sayılar:");
        foreach (int sayi in bolunebilienSayilar)
        {
            if (sayi != 0)
            {
                Console.WriteLine(sayi);
            }
        }

        //3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        while(true)
        {
       
            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            if(sayi>0)
            {
                string[] dizi1= new string[sayi];

                for(int i=0;i<sayi;i++)
                {
                    Console.Write((i+1)+". Kelimeyi girin: ");
                    dizi1[i]=Console.ReadLine();
                }
                for(int i=sayi-1; i>=0;i--)
                {
                    Console.Write(dizi1[i]+" ");
                }
                break;
            }
            else
            {
                Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
                
            }
            
        
        }

        //4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

       Console.WriteLine("Bir cümle giriniz: ");
       string cumle=Console.ReadLine();
       
       int harfSayisi=0;
       int kelimeSayisi=0;

       foreach(char a in cumle)
       {
            if(char.IsWhiteSpace(a))
            {
                kelimeSayisi++;
            }
            else if(char.IsLetter(a))
            {
                harfSayisi++;
            }
           
       }
        kelimeSayisi++;
        Console.WriteLine("Cümledeki kelime sayısı: "+kelimeSayisi);
        Console.WriteLine("Cümledeki harf sayısı: "+harfSayisi);


        
        
        
    }
}
