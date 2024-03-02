int[] sayilar = { 3, 5, 2, 8, 9 };

Console.WriteLine("Dizinin Eleman Sayısı:" + sayilar.Length);

Console.WriteLine("Dizinin İlk Elemanı:" + sayilar[0]);
Console.WriteLine("Dizinin Son Elemanı:" + sayilar[sayilar.Length-1]);

sayilar[3] = 7;
sayilar.SetValue(15, 2);
int toplam = 0;

for(int i=0;i<sayilar.Length;i++)
{
    int eleman = sayilar[i];
    toplam += eleman;
    Console.Write($"Dizinin {i}.indeksinde {eleman} var\n");
}

Console.WriteLine("Dizinin Elemanlarının Toplamı:{0}", toplam);