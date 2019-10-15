using System;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra;

namespace ConsoleApp {

    static class Program {

        static void Main(string[] args) {
            var startNew = Stopwatch.StartNew();
            startNew.Start();
//            Matrix<double> matrixC;
//            {
//                var matrixA = Matrix<double>.Build.Random(3000, 4000);
//                var matrixB = Matrix<double>.Build.Random(4000, 3000);
//                matrixC = matrixA * matrixB;
//            }
            var result = Fibonacci(47);
            startNew.Stop();
            Console.WriteLine(result);
            Console.WriteLine(startNew.Elapsed);
            // 21 sec
//            Console.WriteLine(unchecked((int) (float) int.MaxValue));
        }

        private static long Fibonacci(int n) {
            return n switch {
                0 => throw new ArgumentException(),
                1 => 1,
                2 => 1,
                3 => 2,
                _ => (Fibonacci(n - 1) + Fibonacci(n - 2))
            };
        }

    }

}