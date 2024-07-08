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
        public List<string> GenerateFizzBuzz(int number)
        {
            var fizzBuzz = new List<string>();
            for (int i = 1; i <= 1000; i++)
            {
                if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        fizzBuzz.Add("wizzwuzz");
                    else if (i % 3 == 0)
                        fizzBuzz.Add("wizz");
                    else if (i % 5 == 0)
                        fizzBuzz.Add("wuzz");
                    else
                        fizzBuzz.Add(i.ToString());
                }
                else
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        fizzBuzz.Add("fizzbuzz");
                    else if (i % 3 == 0)
                        fizzBuzz.Add("fizz");
                    else if (i % 5 == 0)
                        fizzBuzz.Add("buzz");
                    else
                        fizzBuzz.Add(i.ToString());
                }
        }
            return fizzBuzz;
        }
    }
}
