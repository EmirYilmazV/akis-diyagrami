using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("İlk Sayıyı Giriniz");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci Sayıyı  Giriniz");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Üçüncü Sayıyı  Giriniz");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        double toplam = (sayi1 + sayi2);

        double toplam2 = (toplam + sayi3);

        if (toplam2 < 180)
        {
            Console.WriteLine("Sayı 180'den küçük bu bir üçgen değil");
        }
        else if (toplam2 > 180)
        {
            Console.WriteLine("Sayı 180'den büyük bu bir üçgen değil");
        }
        else if (toplam2 == 180)
        {
            Console.WriteLine("Bu bir üçgen!");
        }








    }




}

