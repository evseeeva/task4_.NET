using System;
using System.Collections.Generic;

namespace task4
{
    class Test
    {
        static void Main(string[] args)
        {
            List<TV1generation> tvs = new List<TV1generation>();
            tvs.Add(new TV1generation("Samsung", 22, 80));
            tvs.Add(new TV1generation("LG", 40, 85));
            tvs.Add(new TV1generation("Philips", 29, 85));
            tvs.Add(new TV2generation("Samsung", 50, 88, "Korea"));
            tvs.Add(new TV2generation("Sony", 65, 88, "Japan"));
            tvs.Add(new TV2generation("Thomson", 60, 85, "Singapore"));
            tvs.Add(new TV2generation("Hisense", 70, 85, "China"));
            foreach (TV1generation tv in tvs)
            {
                Console.WriteLine(tv.ToString());
            }
        }
    }
}
