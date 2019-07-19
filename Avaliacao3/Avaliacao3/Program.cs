using System;
using System.Collections.Generic;

namespace Avaliacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Par = new List<int>();
            List<int> Impar = new List<int>();

            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) { Par.Add(i); } else { Impar.Add(i); }
            }
            Print(Par);
            Print(Impar);
            Console.Write("7° Numero:"+Par[6]+"\n");
            Console.WriteLine("20° Numero:"+Impar[19]);
            AcresDesc(Par);
            AcresDesc(Impar);
            Print(Par);
            Print(Impar);
        }
        static void Print(List<int>s)
        {
            foreach (int a in s)
            {if (a.Equals(100) || a.Equals(99)||a.Equals(101))
                    Console.Write(a + ".");
                else Console.Write(a + "-");
            }
            Console.WriteLine("\n");
        }
        static void AcresDesc(List<int> s)
        {
            for(int i = 0; i <= s.Count-1; i++)
            {
                if (s[i] % 2 == 0)
                    s[i] += 1;
                else s[i] -= 1;
            }
            if (s[0] % 2 == 0) { s.Add(100); }
            s.Remove(101);
        }
    }
}
