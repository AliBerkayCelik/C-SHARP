﻿namespace ArraySinifiMetodlari;
class Program
{
    static void Main(string[] args)
    {
        int[] sayiDizisi={23,12,4,86,72,3,11,17};
        Console.WriteLine("****Sırasız Liste****");
        foreach(var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("****Sıralı Dizi****");
        Array.Sort(sayiDizisi);
        foreach(var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Clear
        Console.WriteLine("****Array Clear****");
        Array.Clear(sayiDizisi,2,2);
        foreach(var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Reverse
        Console.WriteLine("****Array Reverse****");
        Array.Reverse(sayiDizisi);
        foreach(var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //Index Of
        Console.WriteLine("*****Index Of*****");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        //Resize
        Console.WriteLine("****Array Resize****");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8]=99;
        foreach(var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        } 
    }
}
