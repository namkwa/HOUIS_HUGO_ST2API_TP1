using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex4
    {
        public static void Rectangles(int N, int M)
        {
            StringBuilder result = new StringBuilder("");
            if (1 <= N && N <= 1000 && 1 <= M && M <= 1000)
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= M; j++)
                    {
                        if (j == 1 && i == 1 || j == M && i == 1 || j == 1 && i == N || j == M && i == N)
                        {
                            result.Append("0");
                        }
                        else if (j == 1 || j == M)
                        {
                            result.Append("|");
                        }
                        else if (i == 1 || i == N)
                        {
                            result.Append("-");
                        }
                        else
                        {
                            result.Append(" ");
                        }
                    }
                    result.Append("\n");
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("wrong values for N and M");
            }
        }
        public static void RectanglesWithStars(int N, int M)
        {
            StringBuilder result = new StringBuilder("");
            if (1 <= N && N <= 1000 && 1 <= M && M <= 1000)
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= M; j++)
                    {
                        if (j == 1 && i == 1 || j == M && i == 1 || j == 1 && i == N || j == M && i == N)
                        {
                            result.Append("0");
                        }
                        else if (j == 1 || j == M)
                        {
                            result.Append("|");
                        }
                        else if (i == 1 || i == N)
                        {
                            result.Append("-");
                        }
                        else if ()
                        {

                        }
                        else
                        {
                            result.Append(" ");
                        }
                    }
                    result.Append("\n");
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("wrong values for N and M");
            }
        }
    }
}
