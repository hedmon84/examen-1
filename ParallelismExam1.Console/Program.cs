using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelismExam1.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //ejercicio 1.
            var evenNumbersFinder = new EvenNumbersFinder(new List<int>
            {
                3,5,6,7,7,314,5,67,148,678,1467,932,67,12,16
            });
            var result = evenNumbersFinder.Execute();
            foreach (var element in result)
            {
                System.Console.WriteLine(element);
            }

            //ejercicio 2.
            //var process = new Process();
            //var result = await process.GetDataAsync();
        }
    }
}
