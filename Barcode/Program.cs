using System;
using System.Collections.Generic;

namespace Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            new BarcodeInterpreter(
                new ManufacturerId(new List<Digit> { new Digit(DigitEnum.One), new Digit(DigitEnum.Two),
                                                     new Digit(DigitEnum.Three), new Digit(DigitEnum.Four),
                                                     new Digit(DigitEnum.Five), new Digit(DigitEnum.Six) }),
                new ProductCode(new List<Digit> { new Digit(DigitEnum.Four), new Digit(DigitEnum.Five), new Digit(DigitEnum.Six),
                                                  new Digit(DigitEnum.Seven), new Digit(DigitEnum.Eight) }),
                new CheckDigitCalculator())
                .Interpret(new Context());
        }
    }
}
