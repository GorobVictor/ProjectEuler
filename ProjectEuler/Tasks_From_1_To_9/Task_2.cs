using System;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_2:Task<int>
    {
        protected override int Result
        {
            get
            {
                int result = 0;
                int a = 1;
                for (int i = 1; i + a < 4000000; i = a - i)
                {
                    if ((i + a) % 2 == 0)
                        result += i + a;
                    a = a + i;
                }

                return result;
            }
        }
    }
}