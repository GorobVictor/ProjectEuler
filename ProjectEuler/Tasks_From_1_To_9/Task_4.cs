using System;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_4 : Task<int>
    {
        protected override int Result
        {
            get
            {
                for (double i = Math.Pow(999, 2); i > 0; i--)
                    if (i / 999 <= 999)
                    {
                        bool check = true;
                        for (int k = 0; k < i.ToString().Length / 2; k++)
                            if (i.ToString()[k] != i.ToString()[i.ToString().Length - k - 1])
                            {
                                check = false;
                                break;
                            }

                        if (check)
                        {
                            check = false;
                            for (int f = 999; f > 1; f--)
                                if (i % f == 0 && i / f <= 999)
                                {
                                    check = true;
                                    break;
                                }

                            if (check)
                                return Convert.ToInt32(i.ToString());
                        }
                    }

                return -1;
            }
        }
    }
}