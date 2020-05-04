using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler.Tasks_From_10_To_19
{
    internal class Task_10 : Task<double>
    {
        protected override double Result
        {
            get
            {
                double result = 0;
                var listNumber = Enumerable.Range(2, 2000000).ToList();
                for (int i = 0; i < listNumber.Count(); i++)
                {
                    int index = listNumber.Count();
                    listNumber = listNumber.Where(x => x % listNumber[i] != 0 || x == listNumber[i]).ToList();
                    if (index == listNumber.Count())
                        break;
                }

                foreach (var number in listNumber)
                    result += number;
                return result;
            }
        }
    }
}