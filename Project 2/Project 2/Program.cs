using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, z, sum, mx, mz;
            Console.WriteLine(" Enter The Number 1 Range : ");
            mx = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter The Number 2 Range : ");
            mz = int.Parse(Console.ReadLine());
            for (x = mx; x <= mz; x++)
            {
                z = 1;
                sum = 0;
                while (z < x)
                {
                    if (x % z == 0)
                        sum += z;
                    z++;
                }
                if (sum == x)

                    Console.WriteLine(x);
            }
            Console.ReadKey();



        }
    }
}
