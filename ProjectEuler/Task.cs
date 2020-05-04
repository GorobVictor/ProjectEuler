using System;

namespace ProjectEuler
{
    internal abstract class Task<T>
    {
        public (T, TimeSpan) GetResult()
        {
            Program.Stopwatch.Start();
            var result = Result;
            Program.Stopwatch.Stop();
            return (result, Program.Stopwatch.Elapsed);
        }

        protected abstract T Result { get; }
    }
}