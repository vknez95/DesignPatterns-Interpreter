using System;
using System.Linq;

namespace Barcode
{
    public class BarcodeInterpreter : IExpression
    {
        private readonly ManufacturerId _manufacturerId;
        private readonly ProductCode _productCode;
        private readonly ICheckDigitCalculator _checkDigitCalculator;

        public BarcodeInterpreter(ManufacturerId manufacturerId, ProductCode productCode,
            ICheckDigitCalculator checkDigitCalculator)
        {
            _manufacturerId = manufacturerId;
            _productCode = productCode;
            _checkDigitCalculator = checkDigitCalculator;
        }

        public void Interpret(Context context)
        {
            Digit checkDigit =
                _checkDigitCalculator.Calculate(
                    _manufacturerId.Digits.Concat(
                        _productCode.Digits).ToList());

            context.Ouput += "|";
            _manufacturerId.Interpret(context);
            context.Ouput += "|";
            _productCode.Interpret(context);
            context.Ouput += "|";
            checkDigit.Interpret(context);
            context.Ouput += "|";

            Console.WriteLine(context.Ouput);
        }
    }
}