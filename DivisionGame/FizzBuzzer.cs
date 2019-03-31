namespace DivisionGame
{
    public class FizzBuzzer : ITurnProcessor
    {
        public string Process(int turn)
        {
            string result = "";
            if (IsFizz(turn))
            {
                result += "Fizz"; 
            }

            if (IsBuzz(turn))
            {
                result += "Buzz";
            }

            if (string.IsNullOrEmpty(result))
            {
                result = turn.ToString();
            }

            return result;
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }
    }
}