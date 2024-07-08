using FizzLibrary.Shared.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary.Shared.Service
{
    public class FizzBuzzService : IFizzBuzz
    {
        public string NumberIsDivisibleBy3(int number)
        {
            return number % 3 == 0 ? "fizz" : "";
        }
        public string NumberIsDivisibleBy3And5(int number)
        {
            return number % 3 == 0 && number %5 == 0 ? "fizzbuzz" : "";
        }
        public string NumberIsDivisibleBy5(int number)
        {
            return number % 5 == 0 ? "buzz" : "";
        }
        public List<int> ReturnVerticalList(int number)
        {
            List<int> ListOfNumbers = Enumerable.Range(1, number).ToList();
            return ListOfNumbers;
        }
    }
}
