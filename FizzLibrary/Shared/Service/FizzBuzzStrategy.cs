using FizzLibrary.Shared.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary.Shared.Service
{
    public class FizzBuzzStrategy
    {
        private readonly List<IFizzBuzz> _strategies;
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

            for (int i = 1; i <= number; i++)
            {
                foreach (var strategy in _strategies)
                {
                    var result = strategy.GenerateFizzBuzz(i);
                    if (result != "")
                    {
                        fizzBuzzList.Add(result);
                        break;
                    }
                }
            }

            return fizzBuzzList;
        }
    }
}
