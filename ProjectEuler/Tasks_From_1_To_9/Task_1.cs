using System;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_1 : Task<int>
    {
        protected override int Result
        {
            get
            {
                int result = 0;
                for (int i = 0; i < 1000; i++)
                    if (i % 3 == 0 || i % 5 == 0)
                        result += i;
                return result;
            }
        }
    }
}