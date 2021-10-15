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
             int total = 0;
             var glasnie = new HashSet<char> { 'a', 'e', 'y', 'u', 'o' };

             Console.WriteLine("Sisestage lause");
             string sõnad = Console.ReadLine().ToLower();

             for (int i = 0; i < sõnad.Length; i++)
             {
                 if (glasnie.Contains(sõnad[i]))
                 {
                     total++;
                 }
             }
             Console.WriteLine("Sinu vokaalide koguarv on: {0}", total);

        }
        public static void Ülesanne2()
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                a[i] = r.Next(-100, 100);
                if (a[i] > -100 && a[i] < 100) count++;
            }
            Console.WriteLine("Count {0}", count);
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
