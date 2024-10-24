using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir sayı girin: ");

        try
        {
            string girdi = Console.ReadLine();
            double sayi = Convert.ToDouble(girdi);
            double kare = sayi * sayi;
            Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen daha küçük bir sayı giriniz.");
        }
        catch (Exception)
        {
            Console.WriteLine("Bir hata oluştu! Lütfen geçerli bir giriş yapın.");
        }
    }
}
