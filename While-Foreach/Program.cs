﻿namespace While_Foreach;
class Program
{
    static void Main(string[] args)
    {
        //While
        // 1 den başlayarak consoledan girilen sayıya kadar (sayı dahil) ortalama hesapalayıp console a yazdırılan program.

        // Console.Write("Lütfen bir sayı giriniz: ");
        // int sayi=int.Parse(Console.ReadLine());
        // int sayac=1;
        // int toplam=0;

        // while(sayac<= sayi)
        // {
        //     toplam +=sayac;
        //     sayac++;
           
        // }
        // Console.WriteLine(toplam/sayi);

        // 'a' dan 'z' ye kadar tüm harfleri console a yazınız.

        // char character='a';
        // while(character < 'z')
        // {
        //     Console.Write(character);
        //     character++;
        // }
        
        Console.WriteLine("*****Foreach Döngüsü*****");
        string[] arabalar={"BMW","Ford","Toyota","Nissan"};

        foreach(var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
