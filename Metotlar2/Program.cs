int Topla(params int[] sayilar)
{
    int toplam = 0;
    for (int i = 0; i < sayilar.Length; i++)
        toplam += sayilar[i];

    return toplam;
}

void DegisTokus(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y= temp;
}

void DegisTokus2(int[] dizi)
{
    int temp = dizi[0];
    dizi[0] = dizi[1];
    dizi[1] = temp;
}

int a = 5;
int b = 3;
int[] d = { 1, 2 };

DegisTokus(ref a, ref b);
DegisTokus2(d);

Console.WriteLine("a: {0} b:{1}", a, b);

Console.WriteLine("dizi[0]: {0} dizi[1]:{1}", d[0], d[1]);

