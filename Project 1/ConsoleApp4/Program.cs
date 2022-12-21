using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" The Value n1:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" The Value n2:");
            int n2 = int.Parse(Console.ReadLine());
            int num, z, x;
            num = n1;
            while (num <= n2)
            {
                x = 0;
                for (z = 2; z < num; z++)
                {

                    if (num % z == 0)
                    {
                        x = 1;
                            break;
                    }

                }
                if (x == 0)
                    Console.WriteLine(num);
                num++;
            }
            return;
            Console.ReadKey();
            
        }
    }
}
