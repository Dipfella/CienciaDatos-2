using System;
using System.Linq;

namespace Taller_1
{
    public static class Utility
    {
        private static readonly Random _random = new Random();

        public static int[] GenerateRandomNumbers(int size)
        {
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = _random.Next(1, 10000);
            }
            return numbers;
        }

        public static int[] GetTopNumbers(int[] numbers, int count)
        {
            count = count / 2;
            return numbers
                .OrderByDescending(n => n)
                .Take(count)
                .ToArray();
        }

        public static void PrintArray(int[] array, string text)
        {
            foreach (int num in array)
            {
                Console.WriteLine(text + num);
            }
        }

        public static void ExportToCSV(string filename, double[] tiempos, int cantTest, int[] canNum) 
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Numero de prueba;Cantidad de numeros;Tiempo (ms)");
                for (int i = 0; i < cantTest; i++)
                {
                    writer.WriteLine($"{i + 1};{canNum[i]};{tiempos[i]:F2}");
                }
            }
        }
    }
}
