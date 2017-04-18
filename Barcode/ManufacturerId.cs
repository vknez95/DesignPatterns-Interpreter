using System;
using System.Collections.Generic;

namespace Barcode
{
    public class ManufacturerId : IExpression
    {
        private readonly IEnumerable<Digit> _digits;

        public ManufacturerId(IEnumerable<Digit> digits)
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