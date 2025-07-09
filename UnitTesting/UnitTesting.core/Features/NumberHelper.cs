

namespace UnitTesting.core.Features
{
    public class NumberHelper
    {
    //    public bool IsEven(int number)
    //    {
    //        return number % 2 == 0;
    //    }

    //    public bool IsOdd(int number)
    //    {
    //        return number % 2 != 0;
    //    }

        public enum NumberType
        {
            Odd, Even
        }

        public NumberType GetNumberType(int number)
        {
            return number % 2 == 0 ? NumberType.Even : NumberType.Odd;
        }
    }
}
