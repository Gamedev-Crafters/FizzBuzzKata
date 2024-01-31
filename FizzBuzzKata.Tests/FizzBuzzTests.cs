using System.Collections;

namespace FizzBuzzKata;

/*
 * 1. If the number is a multiple of three, return the string "Fizz".
 * 2. If the number is a multiple of five, return the string "Buzz".
 * 3. If the number is a multiple of both three and five, return the string "FizzBuzz".
 */
public class FizzBuzzTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void Fizz_Buzz_Game(int valueToPlay, string expected)
    {
        var sut = new FizzBuzz();

        var result = sut.PlayFizzBuzz(valueToPlay);
        
        Assert.Equal(expected, result);
    }

    private class TestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 1, "1" },
            new object[] { 2, "2" },
            new object[] { 3, "Fizz" },
            new object[] { 4, "4" },
            new object[] { 5, "Buzz" },
            new object[] { 6, "Fizz" },
            new object[] { 7, "7" },
            new object[] { 8, "8" },
            new object[] { 9, "Fizz" },
            new object[] { 10, "Buzz" },
            new object[] { 11, "11" },
            new object[] { 12, "Fizz" },
            new object[] { 13, "13" },
            new object[] { 14, "14" },
            new object[] { 15, "FizzBuzz" }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}