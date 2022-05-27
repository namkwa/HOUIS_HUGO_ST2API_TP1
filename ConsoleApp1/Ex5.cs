using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Ex5 {
        public static void Tree(int sizeTree, Boolean decorated) {
            int sizeBase = sizeTree * 2 - 1;
            StringBuilder tree = new StringBuilder();
            for (int i = 1; i <= sizeTree; i++) {
                for (int j = 1; j <= sizeBase; j++) {
                    if (j <= sizeTree - i || j >= sizeTree + i) {
                        tree.Append(' ');
                    } else {
                        Random r = new Random();
                        int randomizer = r.Next(0, 36);
                        if (randomizer < 26 && decorated) {
                            tree.Append('*');
                        } else if (randomizer < 33 && decorated) {
                            tree.Append('i');
                        } else if (decorated) {
                            tree.Append('o');
                        } else {
                            tree.Append('*');
                        }

                    }
                }
                tree.Append('\n');
            }
            tree.Append(new String(' ', sizeTree - 2));
            tree.Append("| |");
            tree.Append(new String(' ', sizeTree - 2));
            Console.WriteLine(tree.ToString());
        }
    }
}
