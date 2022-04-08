using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
             //ekrana girilen sayılar kadar olan tek sayıları ekrana yazdır.
        //     Console.WriteLine("lütfen bir değer giriniz");
        //  int deger = Convert.ToInt32(Console.ReadLine());
        //  for (int i = 0; i < deger; i++)
        //  {
        //      if(i%2 == 0)
        //      {
        //          Console.WriteLine(i);
        //      }
        
        // 1 ile 1000 arasındaki tek ve çift sayıların kendi içerisinde toplamını yazdır.
        int tekdeger = 0;
        int ciftdeger = 0;
        for (int i = 1; i <= 1000; i++)
        
         if(i%2==1) 
            tekdeger += i;
        else    
            ciftdeger += i;
         
            Console.WriteLine("Tek Toplam:" +tekdeger);
            Console.WriteLine("Çift Toplam:" +ciftdeger);
        }
    }
}
