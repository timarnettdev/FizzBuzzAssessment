using FizzBuzz.Services.Services;
using FizzBuzz.Services.Services.Interfaces;
using NUnit.Framework;

namespace FizzBuzz.Tests.Unit
{
    [TestFixture]
    public class FizzBuzzServiceTest
    {
        private IFizzBuzzService _fizzBuzzService;
        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        public void FizzBuzz_ReturnsString()
        {
            // Testing multiples of 3
            Assert.That(_fizzBuzzService.FizzBuzz(3), Is.EqualTo("Fizz"));
            Assert.That(_fizzBuzzService.FizzBuzz(6), Is.EqualTo("Fizz"));
            Assert.That(_fizzBuzzService.FizzBuzz(9), Is.EqualTo("Fizz"));

            // Testing multiples of 5
            Assert.That(_fizzBuzzService.FizzBuzz(5), Is.EqualTo("Buzz"));
            Assert.That(_fizzBuzzService.FizzBuzz(10), Is.EqualTo("Buzz"));
            Assert.That(_fizzBuzzService.FizzBuzz(20), Is.EqualTo("Buzz"));

            // Testing multiples of both 3 and 5
            Assert.That(_fizzBuzzService.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
            Assert.That(_fizzBuzzService.FizzBuzz(30), Is.EqualTo("FizzBuzz"));
            Assert.That(_fizzBuzzService.FizzBuzz(45), Is.EqualTo("FizzBuzz"));

            // Testing numbers that are not multiples of 3 or 5
            Assert.That(_fizzBuzzService.FizzBuzz(1), Is.EqualTo("Divided 1 by 3 and 5"));
            Assert.That(_fizzBuzzService.FizzBuzz(2), Is.EqualTo("Divided 2 by 3 and 5"));
            Assert.That(_fizzBuzzService.FizzBuzz(4), Is.EqualTo("Divided 4 by 3 and 5"));
            Assert.That(_fizzBuzzService.FizzBuzz(7), Is.EqualTo("Divided 7 by 3 and 5"));
            Assert.That(_fizzBuzzService.FizzBuzz(8), Is.EqualTo("Divided 8 by 3 and 5"));
            Assert.That(_fizzBuzzService.FizzBuzz(11), Is.EqualTo("Divided 11 by 3 and 5"));

            //Testing invalid inputs
            Assert.That(_fizzBuzzService.FizzBuzz(0), Is.EqualTo("Invalid item"));
            Assert.That(_fizzBuzzService.FizzBuzz(0), Is.EqualTo("Invalid item"));
            Assert.That(_fizzBuzzService.FizzBuzz(0), Is.EqualTo("Invalid item"));
        }
    }
}
