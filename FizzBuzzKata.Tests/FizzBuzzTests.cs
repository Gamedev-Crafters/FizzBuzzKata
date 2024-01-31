namespace FizzBuzzKata;

/*
 * 1. If the number is a multiple of three, return the string "Fizz".
 * 2. If the number is a multiple of five, return the string "Buzz".
 * 3. If the number is a multiple of both three and five, return the string "FizzBuzz".
 */
public class FizzBuzzTests
{
    [Fact]
    public void Fizz_Buzz_Game()
    {
        var sut = new FizzBuzz();
        var playValue = 5;

        var result = sut.PlayFizzBuzz(playValue);
        
        Assert.Equal("Buzz", result);
    }
}