namespace UnitTesting.core.Features
{
    public class AgeValidation
    {
        public bool IsAdult(int age)
        {
            return age >= 18;
        }
        public bool IsSenior(int age)
        {
            return age >= 65;
        }
        public bool IsMinor(int age)
        {
            return age < 18;
        }
    }
}
