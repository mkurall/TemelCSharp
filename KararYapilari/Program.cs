float n1,n2,n3;
float ort;

Console.Write("1.Notu Girin: ");
n1 = Convert.ToSingle(Console.ReadLine());
Console.Write("2.Notu Girin: ");
n2 = Convert.ToSingle(Console.ReadLine());
Console.Write("3.Notu Girin: ");
n3 = Convert.ToSingle(Console.ReadLine());

ort = (n1+n2+n3)/3;

Console.WriteLine("Ortalama:{0:f2} {1}",ort,ort);

if(ort>=85)
{
    Console.Write("TAKDİR BELGESİ");
}
else if(ort>=70)
{
    Console.Write("TEŞEKKÜR BELGESİ");
}
else if(ort>=50)
{
    Console.Write("DOĞRUDAN SINIF GEÇTİ");
}
else
{
    Console.Write("SINIFTA KALDI");
}