﻿namespace HataYonetimi;
class Program
{
    static void Main(string[] args)
    {
        // try
        // {
        //     Console.WriteLine("Bir Sayı Giriniz: ");
        //     int sayi=Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Girmiş olduğunuz sayı: "+ sayi);
        // }
        // catch(Exception ex)
        // {
        //     Console.WriteLine("Hata: "+ex.Message.ToString());
        // }
        // finally
        // {
        //     Console.WriteLine("İşlem Tamamlandı");
        // }

        try
        {
            // int a=int.Parse(null);
            // int a=int.Parse("Test");
            int a= int.Parse("-200000000000");
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz.");
            Console.WriteLine(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Format uygun değil.");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Çok büyük yada çok küçük bir değer girdiniz.");
            Console.WriteLine(ex);
        }

        

    }
}
