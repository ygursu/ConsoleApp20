{
    int sayi, hak = 5;
    bool durum = false;
    Random rastgele = new Random();
    int rastgeleSayi = rastgele.Next(0, 100);
    for (int i = hak; i > 0; i--)
    {
        Console.WriteLine("Hak {0}", i);
        Console.Write("Tahmininiz :");
        sayi = int.Parse(Console.ReadLine());
        if (sayi == rastgeleSayi)
        {
            Console.WriteLine("Tebrikler");
            durum = true;
            break;
        }
    }
    if (!durum)
    {
        Console.WriteLine("Tekrar Deneyin!");
        Console.WriteLine("Sayı : {0}", rastgeleSayi);
    }
    Console.ReadKey();
