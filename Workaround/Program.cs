using Business.Concrete;
using Entitiess.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degisken();
            
            Vatandas vatandas = new Vatandas();

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();
            int sonuc = Topla(6, 58);

            // diziler /Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            /*Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);*/

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            //ogrenciler[3] = "Gökhan";
            ogrenciler = new string[4];
            ogrenciler[3] = "Gökhan";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            // int, double,bool DEĞERDİR
            // bir kere atandıktan sonra atanan değer değiştiğinde o değer değişmez 1 kere atandı ve bitti.
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;


            //string refarans tip (değer tip gibi çalışır, aslında bir char arraydir)



            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";

            Console.WriteLine(sehirler2[0]);



            Person person1 = new Person();
            person1.FirstName = "HAMZA";
            person1.LastName = "ÇETİN";
            person1.DateOfBrithYear = 2005;
            person1.NationalIdentitiy= 12345678910;



            Person person2 = new Person();
            person2.FirstName = "Murat";


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //My List
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");

            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager  = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "No Name")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }

        private static void Degisken()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;  //db(database/veritabanı) den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Hamza";
            string soyad = "Çetin";
            int dogumYili = 2005;
            long tcNo = 55566688879;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
    //pascal casing(kelimelerin ilk harfi büyük başlaması)
    public class Vatandas
    {
        public string Ad { get; set; } // get set özelliklerini istersek değiştirebilriz {} kullanarak(noktalı virgülü kaldırarak)
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
