using System;

namespace Widget {
    class Program {
        static void Main(string[] args) {

            var w1 = new Widget("LARGE", "RED");
            Console.WriteLine($"A {w1.Size}, {w1.Color} widget costs {w1.Price()}");

            var w2 = new Widget("SMALL", "WHITE");
            Console.WriteLine($"A {w2.Size}, {w2.Color} widget costs {w2.Price()}");

            var w3 = new Widget("MEDIUM", "BLUE");
            Console.WriteLine($"A {w3.Size}, {w3.Color} widget costs{w3.Price()}");
        }
    }
}
