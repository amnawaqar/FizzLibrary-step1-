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
        public string GenerateFizzBuzz(int number)
        {
            return (number % 3 == 0 && number % 5 == 0) ? "fizzbuzz" : "";
        }
    }
    public class FizzService : IFizzBuzz
    {
        public string GenerateFizzBuzz(int number)
        {
            return number % 3 == 0 ? "fizz" : "";
        }
    }
    public class BuzzService : IFizzBuzz
    {
        public string GenerateFizzBuzz(int number)
        {
            return number % 5 == 0 ? "buzz" : "";
        }
    }
    public class NumberService : IFizzBuzz
    {
        public string GenerateFizzBuzz(int number)
        {
            return (number % 3 != 0 && number % 5 != 0) ? number.ToString() : "";
        }
    }
}
