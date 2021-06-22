using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int count = 0;
            for (int i = 0; i < candles.Count(); i++)
            {
                count = 1;
                for (int j = i + 1; j < candles.Count(); j++)
                {
                    if (candles[i] == candles[j]) count++;
                }
                if (count > 1) return count;
            }
            return default(int);
        }
        
        public static void StairCase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int j = n - i;
                for (; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int v = 0; v < i; v++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
