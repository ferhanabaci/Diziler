using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama 
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","kus","köpek","maymun"};
            int[] dizi ;
            dizi = new int[5];
            //Dİzilere deger atama ve erişim
            renkler[0]= "mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);  
            //Döngüler dizi kullanımı 
            //klvyeden girilen n tane sayının   ortalamasını hesalmayan program
            Console.WriteLine("lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu= int.Parse(Console.ReadLine());

            int[] sayıDizisi= new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("lütfen {0}. sayısı giriniz", i+1);
                sayıDizisi[i]=int.Parse(Console.ReadLine());
                
            }
            int toplam=0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
                
            }
            Console.WriteLine("Ortalama:"+toplam/diziUzunlugu);

        }
    }
}
