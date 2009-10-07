
namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        public static string SayFizzBuzz(int number)
        {
            if (NumberIsDivisibleByThreeAndFive(number)) return "FizzBuzz";

            return NumberIsDivisibleByThree(number) ? "Fizz" : NumberIsDivisibleByFive(number) ? "Buzz" : number.ToString();
        }

        private static bool NumberIsDivisibleByThreeAndFive(int number)
        {
            return (NumberIsDivisibleByThree(number) && NumberIsDivisibleByFive(number));
        }

        private static bool NumberIsDivisibleByThree(int number)
        {
            return number % 3 == 0 ? true : false;
        }

        private static bool NumberIsDivisibleByFive(int number)
        {
            return number % 5 == 0 ? true : false;
        }
    }
}
