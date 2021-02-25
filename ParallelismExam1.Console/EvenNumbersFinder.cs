using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelismExam1.Console
{
    public class EvenNumbersFinder
    {
        private readonly IEnumerable<int> _values;

        public EvenNumbersFinder(IEnumerable<int> values)
        {
            this._values = values;
        }

        public IEnumerable<int> Execute()
        {
            return FindEvenNumbers(_values.ToArray(), 0, _values.Count());
        }

        private IEnumerable<int> FindEvenNumbers(int[] listOfValues, int start, int end)
        {
            var evenNumbers = new List<int>();
            for (var i = start; i < end; i++)
            {
                if (listOfValues[i] % 2 == 0)
                {
                    evenNumbers.Add(listOfValues[i]);
                }
            }
            return evenNumbers;
        }
    }
}
