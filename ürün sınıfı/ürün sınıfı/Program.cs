using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Soru 2: Ürün Sınıfı
Bir Urun sınıfı oluşturun ve özellikleri tanımlayın:
Özellikler:
Ad (string), Fiyat (decimal), Indirim (decimal)
Get/Set:
İndirim için get/set metodları kullanın. İndirimi 0-50% arasında
sınırlandırın.
Yapıcı
Metot: Ad ve fiyat bilgilerini parametre olarak alıp başlatan bir yapıcı
metot tanımlayın.
Metot:
IndirimliFiyat() metodu, indirimli fiyatı döndürsün.*/

namespace ürün_sınıfı
{
   
    class Urun {
        public string Ad { get; set; }
        public decimal Fiyat;
        private decimal İndirim;
        public int flag = 0;
        // indirimi sinirlamak ıcın get set metodunu kullandık
        public decimal İİndirim
        {
            get
            {
                return İndirim;
            }
            set
            {
                if (value <= 50 || value == 0)
                {
                    İndirim = value;
                    flag = 1;
                }
                else
                    Console.WriteLine($"HATA!! {Ad} için indirim 0-50 arasında olmalı\n");
            }
        }
        // yappıcı metod
        public Urun( string ad,decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
        //urunlere ındırımı uygulayan metod
        public decimal İndirimliFiyat(decimal indirim)
        {
            İİndirim = indirim;
            if (flag == 1)
            {
                Fiyat = Fiyat * indirim / 100;
            }
            return Fiyat;
        }
        //urun bılgılerını ekrana yazdıran metod
        public void UrunBilgileriYaz()
        {
            Console.WriteLine($"ürünün adı: {Ad}");
            Console.WriteLine($"ürünün fiyatı: {Fiyat}");
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun("kalem", 10.00m);
            Urun urun2 = new Urun("kitap", 30.00m);
            urun1.UrunBilgileriYaz();
            urun2.UrunBilgileriYaz();
            urun1.İndirimliFiyat(40);
            urun2.İndirimliFiyat(60);
            urun1.UrunBilgileriYaz();
            urun2.UrunBilgileriYaz();
            Console.ReadKey();
        }
    }
}
