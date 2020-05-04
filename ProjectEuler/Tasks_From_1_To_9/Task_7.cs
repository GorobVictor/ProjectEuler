using System;
using System.Collections.Generic;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_7 : Task<int>
    {
        protected override int Result
        {
            get
            {
                var listNumber = new List<int>();
                for (int i = 0;; i++)
                {
                    bool check = true;
                    for (int k = 2; k <= i / 2; k++)
                        if (i % k == 0)
                        {
                            check = false;
                            break;
                        }

                    if (check)
                    {
                        listNumber.Add(i);
                        if (listNumber.Count > 10002)
                            return listNumber[10002];
                    }
                }
            }
        }
    }
}