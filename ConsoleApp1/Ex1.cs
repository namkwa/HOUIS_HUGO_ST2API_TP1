using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex1
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        public static void ex1_1()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
            }
        }
        public static void ex1_2()
        {
            for (int i = 1; i < 11; i += 2)
            {
                for (int j = 1; j < 11; j += 2)
                {
                    if (i * j % 2 == 1)
                    {
                        Console.WriteLine(i + " * " + j + " = " + i * j);
                    }
                }
            }
        }
        public static void ex1_3()
        {
            int N = AskUserForParameter();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(N + " * " + i + " = " + N * i);
            }
        }
    }
}
