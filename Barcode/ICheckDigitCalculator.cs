using System.Collections.Generic;

namespace Barcode
{
    public interface ICheckDigitCalculator
    {
        Digit Calculate(IList<Digit> digits);
    }
}