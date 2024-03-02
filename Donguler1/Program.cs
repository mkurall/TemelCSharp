for(int i = 0;i <= 10;i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("For Döngüsü Bitti");
//---------------------------------------------

int j = 0;

while (j<=10)
{
    Console.WriteLine(j);
    j++;
}

/*
int j = 0;

for (;j<=10;)
{
    Console.WriteLine(j);
    j++;
}
*/

Console.WriteLine("While Döngüsü Bitti");
//---------------------------------------
j = 0;

do
{
    Console.WriteLine(j);
    j++;
} while (j <= 10);

Console.WriteLine("Do-While Döngüsü Bitti");

//5!=5*4*3*2*1
int f = 1;
int s = 6;
for(int i = s;i>=1;i--)
{
    f *= i; // f = f * i;
}

Console.WriteLine("Faktoriyel {0}! = {1}", s, f);
string parola;
int hak = 3;
do
{
    Console.Write("Parolanızı girin:");
    parola = Console.ReadLine();
    hak--;

    
    if (parola == "1234") break;

    if (hak == 0)
    {
        Console.WriteLine("Hakkınız Bitti.. Parolayı bilemediniz.");
        break;
    }

} while (true);


