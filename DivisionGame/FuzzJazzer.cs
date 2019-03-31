namespace DivisionGame
{
    public class FuzzJazzer : ITurnProcessor
    {
        public string Process(int turn)
        {
            string result = "";
            if (IsFuzz(turn))
            {
                result += "Fuzz"; 
            }

            if (IsJazz(turn))
            {
                result += "Jazz";
            }

            if (string.IsNullOrEmpty(result))
            {
                result = turn.ToString();
            }

            return result;
        }

        private static bool IsFuzz(int i)
        {
            return i % 4 == 0;
        }

        private static bool IsJazz(int i)
        {
            return i % 9 == 0;
        }
    }
}