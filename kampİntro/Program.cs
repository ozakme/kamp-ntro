using System;

namespace kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself- Kendini tekrarlama
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisyapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu ");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu ");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu ");
            }

            if (sistemeGirisyapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
         
        }
    }
}
