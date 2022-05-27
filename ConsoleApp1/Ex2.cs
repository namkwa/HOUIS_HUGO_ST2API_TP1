using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Ex2 {
        private static int AskUserForParameter() {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        public static void Prime() {
            for (int i = 2; i < 1001; i++) {
                Boolean isPrime = true;
                int j = 2;
                while (j <= System.Math.Sqrt(i) && isPrime) {
                    isPrime = i % j != 0;
                    j += 1;
                }
                if (isPrime) {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Fibonacci() {
            int N = AskUserForParameter();
            int FTemp0 = 0;
            int FTemp1 = 1;
            int FResult = 0;
            for (int i = 2; i <= N; i++) {
                FResult = FTemp1 + FTemp0;
                FTemp0 = FTemp1;
                FTemp1 = FResult;
            }
            Console.WriteLine("F(" + N + ") = " + FResult);
        }
        public static void Factorial() {
            int N = AskUserForParameter();
            int result = 1;
            for (int i = 2; i <= N; i++) {
                result *= i;
            }
            Console.WriteLine(N + "! = " + result);
        }
    }
}
