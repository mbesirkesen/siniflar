using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bir KiralikArac sınıfı oluşturun. Bu sınıfta araç kiralama işlemleri
için özellikler ve metotlar tanımlayın:
Özellikler:
Plaka (string), GunlukUcret (decimal), MusaitMi (bool)
Yapıcı
Metot: Plaka ve günlük kiralama ücretini alarak başlatan bir yapıcı metot
yazın. MusaitMi varsayılan olarak true olmalı.
Metotlar:
AraciKirala(), AraciTeslimEt() – Bu metotlar aracın uygunluk durumunu
değiştirsin.*/

namespace Araç_Kiralama_Sınıfı
{   public class KiralikArac
    {
        public string Plaka { get; set; }
        public decimal GunlukUcret { get; set; }
        public bool MusaitMi = true;// varsayılan olarak true
        //yapıcı metot
        public  KiralikArac(string plaka,decimal ucret)
        {
            Plaka = plaka;
            GunlukUcret = ucret;
        }
        //arac kıralanırsa musaıtlıgını false yapıo ve arac zaten kıralanmışssa ekrana hata verıo
        public void AraciKirala()
        {
            if (MusaitMi == true)
            {
                Console.WriteLine("Arabayı kiralama başarılı :)\n");
                MusaitMi = false;
            }
            else { Console.WriteLine("HATA!! Araba musait olmadıgı için kiralayamazsınız\n"); }
           
        }
        //arac teslım edıldıkten sonra musaitlik durumunu yıne true yapıo
        public void AraciTeslimEt()
        {
            MusaitMi = true;
            Console.WriteLine("Arabayı teslim ettiginiz için tesekkur ederiz \n");
        }
        //arac bilgilerini yazdıran metot
        public void AracBilgileri()
        {
            Console.WriteLine($"plaka: {Plaka}\ngünlük ücret: {GunlukUcret}");
            if (MusaitMi == true) { Console.WriteLine("musaitlik durumu: arac musait\n"); }
            else { Console.WriteLine("musaitlik durumu: arac suan müsait degil\n"); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KiralikArac arac1 = new KiralikArac("47 MBK 44",4500.00m);
            arac1.AracBilgileri();
            arac1.AraciKirala();
            arac1.AracBilgileri();
            arac1.AraciTeslimEt();
            arac1.AracBilgileri();
            Console.ReadKey();
        }
    }
}
