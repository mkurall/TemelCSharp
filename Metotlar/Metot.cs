using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Metot
    {
        public static int SayiOku(string mesaj)
        {
            Console.Write(mesaj);
            int okunan = int.Parse(Console.ReadLine());
            return okunan;
        }

    }
}
