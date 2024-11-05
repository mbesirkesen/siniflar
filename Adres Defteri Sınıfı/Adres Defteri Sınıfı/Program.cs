using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bir Kisi sınıfı oluşturun ve kişilerin adres defterinde kayıtlarını
tutmak için aşağıdaki özellik ve metotları ekleyin:
Özellikler:
Ad, Soyad, TelefonNumarasi (string türünde)
Yapıcı
Metot: Ad, soyad ve telefon numarasını alarak başlatan bir yapıcı metot
tanımlayın.
Metot:
KisiBilgisi() – Bu metot, kişinin tam adını ve telefon numarasını
döndürsün.*/

namespace Adres_Defteri_Sınıfı
{   public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private string TelefonNumarasi;
        // yapıcı metod
        public  Kisi (string ad, string soyad, string telefon)
        {
            Ad = ad;
            Soyad = soyad;
            telefonnumarasi = telefon;
        }
        // telefonn numarasının hatalı gırılmesıne ızın vermeyen metod
        public string telefonnumarasi 
        {
            get
            {
                return TelefonNumarasi;
            }
            set
            {
                if (value.Length == 11)
                {
                    TelefonNumarasi = value;
                }
                else
                {
                    Console.WriteLine("HATA!! eksik veya hatalı tuşlama yaptınız\n");
                }
            }
        }
       // kısının tam adını ve telefon numarasını donduren metod
        public string KisiBilgisi()
        {
            return $"isim: {Ad} {Soyad}\ntelefon: {TelefonNumarasi}\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi("Muhammed Beşir", "Kesen", "05537139244");
            Console.WriteLine(kisi1.KisiBilgisi());
            Kisi kisi2 = new Kisi("Ahmet", "Kesen", "055371392");
            Console.WriteLine(kisi2.KisiBilgisi());
            Console.ReadKey();
        }
    }
}
