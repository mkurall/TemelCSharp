int tutulan, tahmin, hak = 5;

tutulan = new Random().Next(1, 100);
bool bildimMi = false;

do
{
    Console.WriteLine("1-100 rasında bir sayı tuttum."+tutulan);
    Console.Write("Tahmininiz: ");
    tahmin = int.Parse(Console.ReadLine());

    if(tahmin == tutulan)
    {
        Console.Write("TEBRİKLER BİLDİNİZ..");
        bildimMi = true;
        break;
    }
    else if(tahmin<tutulan)
    {
        Console.WriteLine("Bilemedin. Yukarı");
    }
    else
    {
        Console.WriteLine("Bilemedin. Aşağı");
    }

    hak--;

    //Console.WriteLine("Kalan Hak:" + hak);
    //Console.WriteLine("Kalan Hak: {0}", hak);
    Console.WriteLine($"Kalan Hak: {hak}");

} while (hak>0);

if (!bildimMi)
    Console.WriteLine("ÜZGÜNÜM HAKKINIZ BİTTİ! BİLEMEDİNİZ...");