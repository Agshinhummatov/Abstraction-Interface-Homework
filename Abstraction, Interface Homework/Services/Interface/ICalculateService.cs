using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__Interface_Homework.Services.Interface
{
    public interface ICalculateService
    {
        void SumNumbers(int num1, int num2);
        int GetSumNumbersFromArray(int[] numbers);
    }
}
