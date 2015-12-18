using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop_diamond_strip
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6, space, num2;
            Console.WriteLine("Print paramid");
            for (int i=1; i<=num1; i++) //total number of layer for pramid
            {
                for (space = 1; space <= (num1 - i); space++) //loop for space
                    Console.Write(" ");
                for (num2 = 1; num2 <= i; num2++) //increase the value
                    Console.Write(num2);
                for (num2 = (i - 1); num2 >= 1; num2--) //decrease the value
                    Console.Write(num2);
                
                Console.WriteLine();
            }

        }
    }
}

/*
    int a = 1, b, s=1, n = 5;
            for(;a<= n; s=s * 10+1)
            {
                for(b=n- a;b>=1; b--)
                {
                    Console.Write(" ");
                }
                Console.Write(s * s);
                Console.WriteLine();
                a++;
            }
*/
