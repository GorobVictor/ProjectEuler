using System;
using System.Diagnostics;
using ProjectEuler.Tasks_From_10_To_19;

namespace ProjectEuler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj =new Task_14();
            Console.WriteLine(obj.GetResult());
        }
        internal static readonly Stopwatch Stopwatch = new Stopwatch();
    }
}