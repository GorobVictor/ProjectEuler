using System;

namespace ProjectEuler.Tasks_From_1_To_9
{
    internal class Task_3 : Task<double>
    {
        protected override double Result
        {
            get
            {
                double number = 600851475143;
                for (int i = 2; i < number / 2; i++)
                    if (number % i == 0)
                    {
                        bool check = true;
                        for (int k = 2; k < number / i / 2; k++)
                            if (number / i % k == 0)
                            {
                                check = false;
                                break;
                            }

                        if (check)
                            return number / i;
                    }

                return -1;
            }
        }
    }
}