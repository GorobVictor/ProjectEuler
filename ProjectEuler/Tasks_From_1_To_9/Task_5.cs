using System;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_5 : Task<int>
    {
        protected override int Result
        {
            get
            {
                for (int i = 1;; i++)
                {
                    bool check = true;
                    for (int k = 1; k <= 20; k++)
                        if (i % k != 0)
                        {
                            check = false;
                            break;
                        }

                    if (check)
                        return i;
                }
            }
        }
    }
}