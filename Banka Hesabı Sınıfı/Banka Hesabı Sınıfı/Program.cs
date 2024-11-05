using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bir BankaHesabi sınıfı oluşturun ve şu özellikleri ekleyin:
Özellikler:
HesapNumarasi (string), Bakiye (decimal)
Get/Set:
Bakiye özelliği için sadece sınıf içinden erişilebilen bir set metodu
yazın.
Yapıcı
Metot: Hesap numarasını ve ilk bakiyeyi alarak başlatan bir yapıcı metot
yazın.
Metotlar:
ParaYatir(decimal miktar) ve ParaCek(decimal miktar) metotları yazın. Para
çekme işleminde bakiye yetersizse işlem yapılmamalı.*/

namespace Banka_Hesabı_Sınıfı
{   public class BankaHesabi
    {
        public string HesapNumarasi { get; set; }
        public decimal Bakiye { get; set; }
        
        // yapıcı mmetot
        public BankaHesabi( string hesap,decimal bakiye)
        {
            HesapNumarasi = hesap;
            Bakiye = bakiye;
        }
        // sadece sınıf içinden erişilebilen bakiye güncelleme metodu  
        private void SetBakiye(decimal yeniBakiye)
        {
            Bakiye = yeniBakiye;
        }
        // Para yatırma metodu 
        public void ParaYatir(decimal miktar)
        { if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL");
            }
            else { Console.WriteLine("Yatırılacak miktar pozitif olmalıdır."); }
        } // Para çekme metodu 
        public void ParaCek(decimal miktar)
        {
            if (miktar > 0 && miktar <= Bakiye)
            {   Bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {Bakiye} TL");
            }
            else if (miktar > Bakiye)
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
            else { Console.WriteLine("Çekilecek miktar pozitif olmalıdır."); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankaHesabi hesap1 = new BankaHesabi("1", 1000.00m);
            hesap1.ParaYatir(500.00m); 
            hesap1.ParaCek(300.00m); 
            hesap1.ParaCek(1500.00m);

            Console.ReadKey();
        }
    }
}
