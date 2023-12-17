namespace KitaplikProjesi
{
    public class Program
    {
        static void Main(string[] args)
        {
            int toplamFiyat = 0;
            string secim;
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("     Türkçe Kitaplar Kategorisi       ---     Yabancı Kitaplar Kategorisi     ");
            Console.WriteLine();
            Console.WriteLine(" 1-Çalıkuşu: Reşat Nuri Güntekin       |  7-Tuna Kılavuzu: Jules Verne");
            Console.WriteLine();
            Console.WriteLine(" 2-Yaban: Yakup Kadri Karaosmanoğlu    |  8-Bir Kuzey Macerası: Jack London");
            Console.WriteLine();
            Console.WriteLine(" 3-Sinekli Bakkal: Halide Edip Adıvar  |  9-Altıncı Koğuş: Anton Çehov");
            Console.WriteLine();
            Console.WriteLine(" 4-Tehlikeli Oyunlar: Oğuz Atay        |  10-Kumarbaz: Fyodor Dostoyevski");
            Console.WriteLine();
            Console.WriteLine(" 5-Geçtiğim Günlerden: Hasan Ali Yücel |  11-İki Şehrin Hikayesi: Charles Dickens");
            Console.WriteLine();
            Console.WriteLine(" 6-Kuyucaklı Yusuf: Sabahattin Ali     |  12-Vişne Bahçesi: Anton Çehov");
            Console.WriteLine();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine();

            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası: ");

            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını giriniz: ");
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "1": Console.WriteLine("Çalıkuşu: 12 TL"); break;
                    case "2": Console.WriteLine("Yaban: 14 TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakkal: 16 TL"); break;
                    case "4": Console.WriteLine("Tehlikeli Oyunlar: 11 TL"); break;
                    case "5": Console.WriteLine("Geçtiğim Günlerden: 8 TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yusuf: 13 TL"); break;
                    case "7": Console.WriteLine("Tuna Kılavuzu: 17 TL"); break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası: 4 TL"); break;
                    case "9": Console.WriteLine("Altıncı Koğuş: 5 TL"); break;
                    case "10": Console.WriteLine("Kumarbaz: 10 TL"); break;
                    case "11": Console.WriteLine("İki Şehrin Hikayesi: 13 TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi: 6 TL"); break;
                    default: Console.WriteLine("Böyle bir kitap mevcut değil, lütfen numarayı kontrol edin"); break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite = Console.ReadLine();

                string dosya = @"C:\\Users\\Enes\\OneDrive\\Masaüstü\\Kullanıcı.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("Günün Kitabı: Çalıkuşu");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\Enes\OneDrive\Masaüstü\Kitaplar.txt",
                    FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
            if (islem == '5')
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası: ");
                    secim = Console.ReadLine();
                    if (secim == "1") { toplamFiyat += 12; }
                    else if (secim == "2") { toplamFiyat += 14; }
                    else if (secim == "3") { toplamFiyat += 16; }
                    else if (secim == "4") { toplamFiyat += 11; }
                    else if (secim == "5") { toplamFiyat += 8; }
                    else if (secim == "6") { toplamFiyat += 13; }
                    else if (secim == "7") { toplamFiyat += 17; }
                    else if (secim == "8") { toplamFiyat += 4; }
                    else if (secim == "9") { toplamFiyat += 5; }
                    else if (secim == "10") { toplamFiyat += 10; }
                    else if (secim == "11") { toplamFiyat += 13; }
                    else if (secim == "12") { toplamFiyat += 6; }
                    else
                    {
                        Console.WriteLine("Böyle bir kitap mevcut değil, lütfen numarayı kontrol edin");
                    }
                    Console.WriteLine();
                    Console.Write("Başka bir kitap almak ister misiniz?: ");
                    string cevap = Console.ReadLine();
                    if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "Hayır" || cevap == "HAYIR")
                    {
                        break;
                    }
                }
                Console.WriteLine("Toplam Tutar: " + toplamFiyat);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random random = new Random();
                int sayi = random.Next(1, 100);
                while (sayi != tahmin)
                {
                    Console.Write("Sayı Giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.Write("Daha Küçük ");
                    }
                    else if (tahmin < sayi)
                    {
                        Console.Write("Daha Büyük ");
                    }
                    else
                    {
                        Console.Write("Tebrikler, sayıyı buldunuz");
                        break;
                    }
                }
            }

            Console.Read();
        }
    }
}