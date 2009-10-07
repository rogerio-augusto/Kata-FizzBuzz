using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzGameTest
    {
        IEnumerable<string> gameWords = new List<string>() { "Fizz", "Buzz", "FizzBuzz" };
        IEnumerable<int> fizzNumbers = new List<int>() { 3, 6, 9 };
        IEnumerable<int> buzzNumbers = new List<int>() { 5, 10, 20 };
        IEnumerable<int> fizzBuzzNumbers = new List<int>() { 15, 30, 60 };
        IList<int> otherNumbers = new List<int>() { 1, 2, 7 };

        [TestMethod]
        public void NumbersDivisibleByThreeShouldSay_Fizz()
        {
            foreach (var number in fizzNumbers)
            {
                Assert.AreEqual("Fizz", FizzBuzz.FizzBuzzGame.SayFizzBuzz(number));
            }
        }

        [TestMethod]
        public void NumbersDivisibleByFiveShouldSay_Buzz()
        {
            foreach (var number in buzzNumbers)
            {
                Assert.AreEqual("Buzz", FizzBuzz.FizzBuzzGame.SayFizzBuzz(number));
            }
        }

        [TestMethod]
        public void NumbersDivisibleByThreeAndFiveShouldSay_FizzBuzz()
        {
            foreach (var number in fizzBuzzNumbers)
            {
                Assert.AreEqual("FizzBuzz", FizzBuzz.FizzBuzzGame.SayFizzBuzz(number));
            }
        }

        [TestMethod]
        public void NumbersNotDivisibleByThreeOrFiveShouldSay_NumberName()
        {
            Assert.AreEqual("1", FizzBuzz.FizzBuzzGame.SayFizzBuzz(otherNumbers[0]));
            Assert.AreEqual("2", FizzBuzz.FizzBuzzGame.SayFizzBuzz(otherNumbers[1]));
            Assert.AreEqual("7", FizzBuzz.FizzBuzzGame.SayFizzBuzz(otherNumbers[2]));
        }
    }
}
