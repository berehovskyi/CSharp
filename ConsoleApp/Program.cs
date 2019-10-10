using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex32;

namespace ConsoleApp {

    static class Program {

        static void Main(string[] args) {
            var startNew = Stopwatch.StartNew();
            startNew.Start();
            Matrix<double> matrixC;
            {
                var matrixA = Matrix<double>.Build.Random(3000, 4000);
                var matrixB = Matrix<double>.Build.Random(4000, 3000);
                matrixC = matrixA * matrixB;
            }
            startNew.Stop();
            Console.WriteLine(matrixC);
            Console.WriteLine(startNew.Elapsed);
            // 21 sec
        }

    }

}