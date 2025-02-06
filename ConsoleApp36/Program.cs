using System;

class Program
{
    static void Main(string[] args)
    {
        string[] masalar = new string[8];
        masalar[0] = "";
        masalar[1] = "boş";
        masalar[2] = "boş";
        masalar[3] = "boş";
        masalar[4] = "dolu";
        masalar[5] = "dolu";
        masalar[6] = "dolu";
        masalar[7] = "dolu";

        string[] urunler = new string[30];
        urunler[1] = "Kebap";
        urunler[2] = "Döner";
        urunler[3] = "Tavuk";
        urunler[4] = "Et";
        urunler[5] = "Köfte";
        urunler[6] = "Pizza";
        urunler[7] = "Pizza2";
        urunler[8] = "Pizza3";
        urunler[9] = "Pizza4";
        urunler[10] = "Pizza5";
        urunler[11] = "Makarna";
        urunler[12] = "Makarna2";
        urunler[13] = "Makarna3";
        urunler[14] = "Çay";
        urunler[15] = "Kahve";
        urunler[16] = "Nescafe";
        urunler[17] = "Espresso";
        urunler[18] = "Cappucino";
        urunler[19] = "Ayran";
        urunler[20] = "Kola";
        urunler[21] = "Fanta";
        urunler[22] = "Sprite";
        urunler[23] = "Ice Tea";
        urunler[24] = "Künefe";
        urunler[25] = "Baklava";
        urunler[26] = "Sütlaç";
        urunler[27] = "Imam Bayıldı";

        int[] fiyatlar = new int[30];
        fiyatlar[1] = 220;
        fiyatlar[2] = 200;
        fiyatlar[3] = 240;
        fiyatlar[4] = 260;
        fiyatlar[5] = 180;
        fiyatlar[6] = 180;
        fiyatlar[7] = 160;
        fiyatlar[8] = 170;
        fiyatlar[9] = 165;
        fiyatlar[10] = 190;
        fiyatlar[11] = 140;
        fiyatlar[12] = 130;
        fiyatlar[13] = 150;
        fiyatlar[14] = 15;
        fiyatlar[15] = 40;
        fiyatlar[16] = 45;
        fiyatlar[17] = 50;
        fiyatlar[18] = 55;
        fiyatlar[19] = 20;
        fiyatlar[20] = 35;
        fiyatlar[21] = 35;
        fiyatlar[22] = 35;
        fiyatlar[23] = 40;
        fiyatlar[24] = 120;
        fiyatlar[25] = 100;
        fiyatlar[26] = 80;
        fiyatlar[27] = 90;

        int[,] siparisler = new int[8, 30];
        int[] toplamlar = new int[8];

        int[,] yeniSiparisler = new int[8, 30];
        string[] siparisListesi = new string[100];
        int siparisSayac = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("****** Meşhur Furkan'ın Yeri ******");
            Console.WriteLine("1- Masa");
            Console.WriteLine("2- Siparis");
            Console.WriteLine("3- Hesap");
            Console.WriteLine("4- Kasa");
            Console.WriteLine("0- Cikis");
            Console.Write("Seçiminiz: ");

            string secim = Console.ReadLine();

            if (secim == "0")
            {
                Console.WriteLine("Program kapatılıyor...");
                break;
            }

            if (secim == "1")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("****** Meşhur Furkan'ın Yeri ******");
                    Console.WriteLine("MASALAR");
                    Console.WriteLine("------------------");

                    for (int i = 1; i <= 7; i++)
                    {
                        Console.WriteLine($"Masa {i} [{masalar[i]}]");
                    }

                    Console.WriteLine("------------------");
                    Console.WriteLine("Çıkış [ESC]");
                    Console.WriteLine("Masa no girin:");

                    ConsoleKeyInfo tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    string masaNo = tus.KeyChar.ToString();
                    if (masaNo == "1" || masaNo == "2" || masaNo == "3" ||
                       masaNo == "4" || masaNo == "5" || masaNo == "6" || masaNo == "7")
                    {
                        int masa = int.Parse(masaNo);
                        if (masalar[masa] == "boş")
                        {
                            masalar[masa] = "dolu";
                            Console.WriteLine($"\nMasa {masa} açıldı!");
                        }
                        else
                        {
                            masalar[masa] = "boş";
                            Console.WriteLine($"\nMasa {masa} kapandı!");
                            Array.Clear(siparisler, masa * 30, 30);
                            toplamlar[masa] = 0;
                        }
                        Console.WriteLine("\nDevam için bir tuşa basın...");
                        Console.ReadKey();
                    }
                }
            }

            if (secim == "2")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("****** Meşhur Furkan'ın Yeri ******");
                    Console.WriteLine("SİPARİŞ");
                    Console.WriteLine("------------------");

                    for (int i = 1; i <= 7; i++)
                    {
                        Console.WriteLine($"Masa {i} [{masalar[i]}]");
                    }

                    Console.WriteLine("------------------");
                    Console.WriteLine("Çıkış [ESC]");
                    Console.WriteLine("Masa no girin:");

                    ConsoleKeyInfo tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    string masaNo = tus.KeyChar.ToString();
                    if (masaNo == "1" || masaNo == "2" || masaNo == "3" ||
                       masaNo == "4" || masaNo == "5" || masaNo == "6" || masaNo == "7")
                    {
                        int masa = int.Parse(masaNo);
                        if (masalar[masa] == "dolu")
                        {
                            Array.Clear(yeniSiparisler, masa * 30, 30);
                            Array.Clear(siparisListesi, 0, 100);
                            siparisSayac = 0;

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("****** Meşhur Furkan'ın Yeri ******");
                                Console.WriteLine("MENU");
                                Console.WriteLine("------------------");
                                Console.WriteLine("YEMEKLER                    İÇECEKLER");
                                Console.WriteLine($"1.{urunler[1]} {fiyatlar[1]}TL        14.{urunler[14]} {fiyatlar[14]}TL");
                                Console.WriteLine($"2.{urunler[2]} {fiyatlar[2]}TL        15.{urunler[15]} {fiyatlar[15]}TL");
                                Console.WriteLine($"3.{urunler[3]} {fiyatlar[3]}TL        16.{urunler[16]} {fiyatlar[16]}TL");
                                Console.WriteLine($"4.{urunler[4]} {fiyatlar[4]}TL        17.{urunler[17]} {fiyatlar[17]}TL");
                                Console.WriteLine($"5.{urunler[5]} {fiyatlar[5]}TL        18.{urunler[18]} {fiyatlar[18]}TL");
                                Console.WriteLine($"6.{urunler[6]} {fiyatlar[6]}TL        19.{urunler[19]} {fiyatlar[19]}TL");
                                Console.WriteLine($"7.{urunler[7]} {fiyatlar[7]}TL        20.{urunler[20]} {fiyatlar[20]}TL");
                                Console.WriteLine($"8.{urunler[8]} {fiyatlar[8]}TL        21.{urunler[21]} {fiyatlar[21]}TL");
                                Console.WriteLine($"9.{urunler[9]} {fiyatlar[9]}TL        22.{urunler[22]} {fiyatlar[22]}TL");
                                Console.WriteLine($"10.{urunler[10]} {fiyatlar[10]}TL     23.{urunler[23]} {fiyatlar[23]}TL");
                                Console.WriteLine($"11.{urunler[11]} {fiyatlar[11]}TL     24.{urunler[24]} {fiyatlar[24]}TL");
                                Console.WriteLine($"12.{urunler[12]} {fiyatlar[12]}TL     25.{urunler[25]} {fiyatlar[25]}TL");
                                Console.WriteLine($"13.{urunler[13]} {fiyatlar[13]}TL     26.{urunler[26]} {fiyatlar[26]}TL");
                                Console.WriteLine($"                             27.{urunler[27]} {fiyatlar[27]}TL");

                                if (siparisSayac > 0)
                                {
                                    Console.WriteLine($"\nMasa {masa} Siparişler:");
                                    for (int i = 0; i < siparisSayac; i++)
                                    {
                                        Console.WriteLine($"{i + 1}- {siparisListesi[i]}");
                                    }
                                }

                                Console.WriteLine("\nOnay [Space]");
                                Console.WriteLine("Çıkış [ESC]");
                                Console.WriteLine("Geri [Sol Ok]");
                                Console.Write("\nÜrün no: ");

                                ConsoleKeyInfo tus2 = Console.ReadKey(true);

                                if (tus2.Key == ConsoleKey.Escape)
                                {
                                    break;
                                }
                                else if (tus2.Key == ConsoleKey.Spacebar)
                                {
                                    for (int i = 1; i <= 27; i++)
                                    {
                                        if (yeniSiparisler[masa, i] > 0)
                                        {
                                            siparisler[masa, i] += yeniSiparisler[masa, i];
                                            toplamlar[masa] += yeniSiparisler[masa, i] * fiyatlar[i];
                                        }
                                    }
                                    Console.WriteLine("\nSiparişler eklendi!");
                                    Console.WriteLine("Devam için bir tuşa basın...");
                                    Console.ReadKey();
                                    break;
                                }
                                else if (tus2.Key == ConsoleKey.LeftArrow)
                                {
                                    break;
                                }
                                else
                                {
                                    string urunSecim = Console.ReadLine();
                                    int urunNo;
                                    if (int.TryParse(urunSecim, out urunNo))
                                    {
                                        if (urunNo >= 1 && urunNo <= 27)
                                        {
                                            yeniSiparisler[masa, urunNo]++;
                                            siparisListesi[siparisSayac] = $"{urunler[urunNo]} - {fiyatlar[urunNo]}TL";
                                            siparisSayac++;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nMasa boş!");
                            Console.WriteLine("\nDevam için bir tuşa basın...");
                            Console.ReadKey();
                        }
                    }
                }
            }

            if (secim == "3")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("****** Meşhur Furkan'ın Yeri ******");
                    Console.WriteLine("HESAP");
                    Console.WriteLine("------------------");

                    for (int masa = 1; masa <= 7; masa++)
                    {
                        Console.WriteLine($"Masa {masa} [{masalar[masa]}] - {toplamlar[masa]}TL");
                    }

                    Console.WriteLine("------------------");
                    Console.WriteLine("Çıkış [ESC]");
                    Console.WriteLine("Masa no girin:");

                    ConsoleKeyInfo tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    string masaNo = tus.KeyChar.ToString();
                    if (masaNo == "1" || masaNo == "2" || masaNo == "3" ||
                       masaNo == "4" || masaNo == "5" || masaNo == "6" || masaNo == "7")
                    {
                        int masa = int.Parse(masaNo);
                        if (masalar[masa] == "dolu")
                        {
                            Console.Clear();
                            Console.WriteLine("****** Meşhur Furkan'ın Yeri ******");
                            Console.WriteLine($"MASA {masa} HESAP");
                            Console.WriteLine("------------------");

                            int toplam = 0;
                            for (int i = 1; i <= 27; i++)
                            {
                                if (siparisler[masa, i] > 0)
                                {
                                    int tutar = siparisler[masa, i] * fiyatlar[i];
                                    Console.WriteLine($"{urunler[i]} x{siparisler[masa, i]} = {tutar}TL");
                                    toplam += tutar;
                                }
                            }

                            Console.WriteLine("------------------");
                            Console.WriteLine($"Toplam: {toplam}TL");
                            Console.WriteLine("\nDevam için bir tuşa basın...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nMasa boş!");
                            Console.WriteLine("\nDevam için bir tuşa basın...");
                            Console.ReadKey();
                        }
                    }
                }
            }

            if (secim == "4")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("****** Meşhur Furkan'ın Yeri ******");
                    Console.WriteLine("KASA");
                    Console.WriteLine("------------------");

                    int genelToplam = 0;
                    int[] urunAdet = new int[30];

                    for (int masa = 1; masa <= 7; masa++)
                    {
                        if (toplamlar[masa] > 0)
                        {
                            Console.WriteLine($"Masa {masa}: {toplamlar[masa]}TL");
                            genelToplam += toplamlar[masa];

                            for (int urun = 1; urun <= 27; urun++)
                            {
                                urunAdet[urun] += siparisler[masa, urun];
                            }
                        }
                    }

                    Console.WriteLine("------------------");
                    Console.WriteLine("Satılan Ürünler:");
                    for (int urun = 1; urun <= 27; urun++)
                    {
                        if (urunAdet[urun] > 0)
                        {
                            Console.WriteLine($"{urunler[urun]} x{urunAdet[urun]} = {urunAdet[urun] * fiyatlar[urun]}TL");
                        }
                    }

                    Console.WriteLine("------------------");
                    Console.WriteLine($"Toplam: {genelToplam}TL");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Çıkış [ESC]");

                    ConsoleKeyInfo tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
        }
    }
}