namespace NumberReplacementService.ReplacementImplementation
{
    public class ReplacementImplementationTaskTwo : IReplacementImplementation
    {
        private readonly char _separator = '-';

        public string ReplaceNumber(int number)
        {
            string result = "";

            if (number % 3 == 0)
                result += "fizz" + _separator;

            if (number % 5 == 0)
                result += "buzz" + _separator;

            if (number % 4 == 0)
                result += "muzz" + _separator;

            if (number % 7 == 0)
                result += "guzz" + _separator;

            result = (result != "") ? result[..^1] : "";

            return result;
        }
    }
}
