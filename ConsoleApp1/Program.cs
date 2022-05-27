using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex1: ");
            Ex1.ex1_1();
            Ex1.ex1_2();
            Ex1.ex1_3();
            Console.WriteLine("Ex2: ");
            Ex2.Prime();
            Ex2.Fibonacci();
            Ex2.Factorial();
            //3)d) a recursive function is a function that calls itself
            Console.WriteLine("Ex3: ");
            Ex3.TryCatch();
            Console.WriteLine("Ex4: ");
            Ex4.Rectangles(5, 7);
            Ex4.RectanglesWithStars(9, 6);
            Console.WriteLine("Ex5: ");
            Ex5.Tree(6, false);
            Ex5.Tree(7, true);
        }
    }
}
