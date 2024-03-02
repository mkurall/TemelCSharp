int SayiOku(string mesaj)
{
    Console.Write(mesaj);
    int okunan = int.Parse(Console.ReadLine());
    return okunan;
}

double SayiOkuF(string mesaj)
{
    Console.Write(mesaj);
    double okunan = double.Parse(Console.ReadLine());
    return okunan;
}

double Hesapla(double fiyat, double miktar=1,double indirim=0)
{
    return (fiyat * miktar) * (indirim / 100); 
}


double miktar = SayiOkuF("Aldığınız Ürün Miktarı:");
double birimFiyat = SayiOkuF("Aldığınız Ürünün Birim Fiyatı:");
double indirim = SayiOkuF("İndirim Oranı:");

double tutar = Hesapla(birimFiyat, miktar, indirim);

Console.Write("Tutar : {0:f2}", tutar);

