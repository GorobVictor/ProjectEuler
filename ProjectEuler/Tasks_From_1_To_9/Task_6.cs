using System;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_6 : Task<int>
    {
        protected override int Result
        {
            get
            {
                int sumOne = 0;
                int sumTwo = 0;
                for (int i = 0; i <= 100; i++)
                {
                    sumOne += (int) Math.Pow(i, 2);
                    sumTwo += i;
                }

                return Math.Abs(sumOne - (int) Math.Pow(sumTwo, 2));
            }
        }
    }
}