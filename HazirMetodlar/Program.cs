using Metotlar;

namespace HazirMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = Metot.SayiOku("Bir sayı gir:");
            int sayi2 = Metot.SayiOku("Bir sayı gir:");

            Console.WriteLine("Küçük olan:" + Math.Min(sayi1, sayi2));
            Console.WriteLine("Büyük olan:" + Math.Max(sayi1, sayi2));
            Console.WriteLine("Üssü:" + Math.Pow(sayi1, sayi2));
            Console.WriteLine(Math.PI);

            string str = "********Bu gün 02 Mart Cumartesi. Btk C# Veritabanı Atölyesi kursundayız. ";

            Console.WriteLine("Btk İçerir Mi: " + str.Contains("Btk"));
            Console.WriteLine("C# ifadesi {0}. indexte", str.IndexOf("C#"));
            Console.WriteLine(str.TrimStart('*'));

            string[] dizi = str.Split('.');

            foreach (string s in dizi)
            {
                Console.WriteLine("Satır:" + s);
            }

        }
    }

}