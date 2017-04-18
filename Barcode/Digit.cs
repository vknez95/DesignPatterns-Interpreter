using System;

namespace Barcode
{
    public class Digit : IExpression
    {
        private readonly DigitEnum _digitEnum;

        public Digit(DigitEnum digitEnum)
        {
            _digitEnum = digitEnum;
        }

        public void Interpret(Context context)
        {
            context.Ouput += (int)_digitEnum;
        }

        public DigitEnum DigitEnum => _digitEnum;
    }
}