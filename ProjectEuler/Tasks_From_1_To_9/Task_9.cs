using System;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_9 : Task<double>
    {
        protected override double Result
        {
            get
            {
                for (int a = 1; a <= 1000; a++)
                for (int b = 1; b <= 1000 - a; b++)
                    if (a + b < 1000)
                        for (int c = 1; c <= 1000 - a - b; c++)
                            if (a + b + c == 1000)
                                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                                    return a * b * c;
                                else break;
                            else if (a + b + c < 1000) continue;
                            else break;
                    else break;
                return -1;
            }
        }
    }
}