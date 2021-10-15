using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseisev_töö_Blinov
{
    class tunnitöö
    {
        public static void Ülesanne1()
        {
            Console.WriteLine("Sisestage suvalise pikkusega string:");
            string str = Console.ReadLine();
            Console.WriteLine("Sisestage märk, et leida selle esinemise protsent stringist:");
            char sym = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int length = str.Length;
            char[] strArr = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (strArr[i] == sym)
                {
                    counter++;
                }
            }
            double lengthDouble = Convert.ToDouble(length);
            double counterDouble = Convert.ToDouble(counter);
            double prc = (counterDouble / lengthDouble) * 100;
            Console.WriteLine($"Märgi esinemise protsent {sym} on võrdne {prc}%");

        }
        public static void Ülesanne2()
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            for (var i = 0; i < n; i++)
                a[i] = r.Next(-2000, 2000);
            Console.WriteLine("Count {0}", a.Count(x => x > -100 && x < 100));

        }

        public static void Ülesanne3()
        {
            Console.Write("Sisestage raha : ");
            double money = double.Parse(Console.ReadLine());
            double tax;
            if (money < 1000)
            {
                tax = .05 * money;
            }
            else if (money <= 10000)
            {
                tax = .08 * money;
            }
            else
            {
                tax = .085 * money;
            }

            Console.WriteLine("Tulumaks {0:C}", tax);

        }
    }
}
