using FizzBuzz.Api.Models;
using FizzBuzz.Services.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : BaseController
    {
        IFizzBuzzService _fizzBuzzService;
        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpGet]
        public FizzBuzzResult Get(int number)
        {
            return new FizzBuzzResult { number = number, message = _fizzBuzzService.FizzBuzz(number) };
        }

        [HttpPost]
        public List<FizzBuzzResult> FizzBuzz(List<int> listNumbers)
        {
            List<FizzBuzzResult> result = new List<FizzBuzzResult>();
            foreach(int number in listNumbers)
            {
                result.Add(new FizzBuzzResult { number = number, message = _fizzBuzzService.FizzBuzz(number) });
            }
            
            return result;
        }
    }
}
