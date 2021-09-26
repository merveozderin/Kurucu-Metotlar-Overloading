using System;

namespace Kurucu_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kurucu fonksiyon nesne tanımlaması
            Calisan calisan1 = new Calisan("Merve", "Özderin", 12345678, "ARGE") ;
             Console.WriteLine("*******Çalışan 1*******") ;
            calisan1.CalisanBilgileri() ;
            // calisan1.Ad = "Merve" ;
            // calisan1.Soyad = "Özderin" ;
            // calisan1.No = 12345678 ;
            // calisan1.Departman = "ARGE" ;

            Calisan calisan2 = new Calisan() ;
            calisan2.Ad = "Deniz" ;
            calisan2.Soyad = "Gökyüzü" ;
            calisan2.No = 87654321 ;
            calisan2.Departman = "İnsan Kaynakları" ;
            
            Console.WriteLine("*******Çalışan 2*******") ;
            calisan2.CalisanBilgileri() ;

            Calisan calisan3 = new Calisan("Mavi", "Kırmızı") ;
            Console.WriteLine("*******Çalışan 3*******") ;
            calisan3.CalisanBilgileri() ;
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        // Kurucu fonksiyonlar
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad ;
            this.Soyad = soyad ;
            this.No = no ;
            this.Departman = departman ;
        }

         public Calisan(string ad, string soyad)
        {
            this.Ad = ad ;
            this.Soyad = soyad ;
        }
        public Calisan()
        {}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad) ;
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad) ;
            Console.WriteLine("Çalışanın Numarası:{0}", No) ;
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman) ;
        }

    }
}
