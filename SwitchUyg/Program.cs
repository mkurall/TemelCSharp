Console.ForegroundColor = ConsoleColor.White;
Console.Write("Bir gün numarası girin[0-6]:");

int n = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Blue;

switch(n)
{
    case 0: Console.Write("PAZAR");break;
    case 1: Console.Write("PAZARTESİ");break;
    case 2: Console.Write("SALI");break;
    case 3: Console.Write("ÇARŞAMBA");break;
    case 4: Console.Write("PERŞEMBE");break;
    case 5: Console.Write("CUMA");break;
    case 6: Console.Write("CUMARTESİ");break;
    default:Console.Write("Hatalı Gün!");break;
}
