using System;
using System.Collections.Generic;

namespace Barcode
{
    public class ProductCode : IExpression
    {
        private readonly IEnumerable<Digit> _digits;

        public ProductCode(IEnumerable<Digit> digits)
        {
            _digits = digits;
        }

        public void Interpret(Context context)
        {
            foreach (Digit digit in _digits)
                digit.Interpret(context);
        }

        public IEnumerable<Digit> Digits => _digits;
    }
}