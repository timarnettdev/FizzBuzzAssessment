using FizzBuzz.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services
{
    public class FizzBuzzService: IFizzBuzzService
    {
        public FizzBuzzService() { }

        public string FizzBuzz(int number)
        {
            if (number == 0)
                return "Invalid item";
            else if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else return "Divided " + number + " by 3 and 5";
        }
    }
}
