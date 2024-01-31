namespace FizzBuzzKata;

public class FizzBuzz
{
    public string PlayFizzBuzz(int playValue)
    {
        if (playValue % 5 == 0 && playValue % 3 == 0)
            return "FizzBuzz";
        if(playValue % 3 == 0)
        {
            return "Fizz";
        }

        if(playValue % 5 == 0)
        {
            return "Buzz";
        }

        return playValue.ToString();
    }
}