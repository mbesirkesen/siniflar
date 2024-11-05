using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bir Kutuphane sınıfı oluşturun ve bu sınıfta kitap ekleme ve listeleme
özelliklerini ekleyin:
Özellik:
Kitaplar (List<Kitap> türünde)
Yapıcı
Metot: Kitap listesi boş olarak başlatılsın.
Metotlar:
KitapEkle(Kitap yeniKitap) – Bu metot kitap eklesin ve KitaplariListele()
metodu tüm kitapları ekrana yazdırsın. this anahtar kelimesini kullanarak
eklenen kitabın kütüphaneye ait olduğunu belirtin.*/

namespace Kütüphane_Sınıfı
{   // listede kullanablmek icin kitap sınıfı olusturduk
    public class Kitap
    {
        public string Baslik { get; private set; }
        public string Yazar { get; private set; }
        // Yapıcı metot 
        public Kitap(string baslik, string yazar)
        {
            Baslik = baslik;
            Yazar = yazar;
           
        }
        // Kitap bilgilerini döndüren metot 
        public string KitapBilgisi()
        {
            return $"Başlık: {Baslik}\nYazar: {Yazar}\n";
        }
    }
    public class Kutuphane
    {
    public List<Kitap> Kitaplar { get; private set; }

    // Yapıcı metot
    public Kutuphane()
    {
        Kitaplar = new List<Kitap>();
    }

    // Kitap ekleme metodu
    public void KitapEkle(Kitap yeniKitap)
    {
        Kitaplar.Add(yeniKitap);
        Console.WriteLine($"Kitap eklendi:\n{yeniKitap.KitapBilgisi()}\n");
        this.KitaplariListele(); // Eklenen kitabın kütüphaneye ait olduğunu belirtioz
    }

    // Kitapları listeleme metodu
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine(kitap.KitapBilgisi());
        }
    }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();
            Kitap kitap1 = new Kitap("sefiller", "besir kesen"); 
            Kitap kitap2 = new Kitap("donusum", "franz kafka"); 
            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);
            Console.ReadKey();
        }
    }
}
