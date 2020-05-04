using System;
using System.Collections.Generic;
using Microsoft.SqlServer.Server;

namespace ProjectEuler.Tasks_From_10_To_19
{
    internal class Task_12 : Task<int>
    {
        protected override int Result
        {
            get
            {
                int step = 500*2;
                int result = -1;
                int number = TriangleNumbers(step - 1);
                for (int i = step;; i++)
                {
                    number += i;
                    int numberOfDividers = 1;
                    List<Task_NumberDegree> listNumber = new List<Task_NumberDegree>();
                    for (int k = 2;; k++)
                        if ((listNumber.Count == 0 ? number : listNumber[listNumber.Count - 1].Number) % k == 0)
                            listNumber.Add(new Task_NumberDegree(
                                FindDeegre(listNumber.Count == 0 ? number : listNumber[listNumber.Count - 1].Number,
                                    k,
                                    0)));
                        else if (listNumber.Find(x => x.Number == 1) != null)
                            break;
                    for (int k = 0; k < listNumber.Count; k++)
                        numberOfDividers *= listNumber[k].Deegre + 1;

                    if (numberOfDividers >= 500)
                    {
                        result = number;
                        break;
                    }
                }

                return result;
            }
        }

        int TriangleNumbers(int number)
        {
            if (number == 1 || number == 0 || number == -1)
                return number;
            else return number + TriangleNumbers(number - 1);
        }

        (int, int) FindDeegre(int number, int divider, int deegre)
        {
            if (number % divider != 0)
                return (number, deegre);
            else return FindDeegre(number / divider, divider, ++deegre);
        }

        class Task_NumberDegree
        {
            public Task_NumberDegree((int, int) number)
            {
                Number = number.Item1;
                Deegre = number.Item2;
            }

            public int Number { get; set; }
            public int Deegre { get; set; }
        }
    }
}