using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex3
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }
        public static void TryCatch()
        {
            for (int i = -3; i < 4; i++)
            {
                try
                {
                    Console.WriteLine((double)10 / (double)PowerFunction(i));
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
