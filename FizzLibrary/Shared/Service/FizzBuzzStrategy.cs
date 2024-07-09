using FizzLibrary.Shared.Interface;
using System;
namespace FizzLibrary.Shared.Service
{
        public class FizzBuzzStrategy
        {
            private readonly List<IFizzBuzz> _strategies;
            private readonly Func<DateTime> _dateProvider;

            public FizzBuzzStrategy()
            {
                _strategies = new List<IFizzBuzz>
            {
                new FizzBuzzService(),
                new FizzService(),
                new BuzzService(),
                new NumberService()
            };
            }

            public List<string> GenerateFizzBuzz(int number)
        {  
            var fizzBuzzList = new List<string>();
            bool isWednesday = DateTime.Now.DayOfWeek == DayOfWeek.Wednesday;

                for (int i = 1; i <= number; i++)
                {
                    foreach (var strategy in _strategies)
                    {
                        var result = strategy.GenerateFizzBuzz(i);
                        if (result != "")
                        {
                            if (isWednesday)
                            {
                                result = result.Replace("fizz", "wizz").Replace("buzz", "wuzz");
                            }
                            fizzBuzzList.Add(result);
                            break;
                        }
                    }
                }
                return fizzBuzzList;
            }
    }
    }
