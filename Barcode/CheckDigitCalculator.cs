using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace Barcode
{
    public class CheckDigitCalculator : ICheckDigitCalculator
    {
        public Digit Calculate(IList<Digit> digits)
        {
            int odd =
                digits
                .GetOddPositions()
                .Select(digit => (int)digit.DigitEnum)
                .Sum() * 3;

            int even =
                digits
                .GetEvenPositions()
                .Select(digit => (int)digit.DigitEnum)
                .Sum();

            int sum = odd + even;

            int nearestMultipleOf10 = IntUtility.GetNearestMultiple(sum, 10);

            return new Digit((DigitEnum)(nearestMultipleOf10 - sum));
        }
    }
}