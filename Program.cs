using System;
using System.Diagnostics;

namespace Taller_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random _random = new Random();
            int cantTest = 40;
            double[] tiempos = new double[cantTest];
            int[] aCanNum = new int[cantTest];


            for (int test = 0; test < cantTest; test++)
            {
                int cantNum = _random.Next(100, 1000);
                Console.WriteLine("\n//-----------------------------------------------------//\n");
                Console.WriteLine("Cantidad de numeros: " + cantNum);
                Console.WriteLine("Test #" + (test + 1) + ": \n");
                Stopwatch stopwatch = Stopwatch.StartNew();
                int[] randomNum = Utility.GenerateRandomNumbers(cantNum);
                Utility.PrintArray(randomNum, "Números Array: ");
                Console.WriteLine();
                int[] topNum = Utility.GetTopNumbers(randomNum, cantNum);
                stopwatch.Stop();
                Utility.PrintArray(topNum, "Top números Array: ");
                tiempos[test] = stopwatch.Elapsed.TotalMilliseconds;
                aCanNum[test] = cantNum;
            }
            Utility.ExportToCSV("results.csv", tiempos, cantTest, aCanNum);
        }
    }
}
    