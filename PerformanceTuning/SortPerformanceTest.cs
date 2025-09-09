using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PerformanceTuning
{
    public static class SortPerformanceTest
    {
        public static void Run()
        {
            const int size = 100_000;
            var random = new Random();
            var data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = random.Next();

            // BubbleSort
            var bubbleData = (int[])data.Clone();
            var bubbleWatch = Stopwatch.StartNew();
            try
            {
                SortService.BubbleSort(bubbleData);
                bubbleWatch.Stop();
                Console.WriteLine($"BubbleSort: {bubbleWatch.ElapsedMilliseconds} ms");
            }
            catch (Exception ex)
            {
                bubbleWatch.Stop();
                Console.WriteLine($"BubbleSort failed: {ex.Message}");
            }

            // QuickSort
            var quickData = (int[])data.Clone();
            var quickWatch = Stopwatch.StartNew();
            SortService.QuickSort(quickData);
            quickWatch.Stop();
            Console.WriteLine($"QuickSort: {quickWatch.ElapsedMilliseconds} ms");

            // ParallelSort
            var parallelData = (int[])data.Clone();
            var parallelWatch = Stopwatch.StartNew();
            SortService.ParallelSort(parallelData);
            parallelWatch.Stop();
            Console.WriteLine($"ParallelSort: {parallelWatch.ElapsedMilliseconds} ms");
        }
    }
}
