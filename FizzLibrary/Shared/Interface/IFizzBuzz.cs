namespace FizzLibrary.Shared.Interface
{
    public interface IFizzBuzz
    {
        string NumberIsDivisibleBy3(int number);
        string NumberIsDivisibleBy5(int number);
        string NumberIsDivisibleBy3And5(int number);
        List<int> ReturnVerticalList(int number);
    }
}
