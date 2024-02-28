namespace NumberReplacementService.ReplacementImplementation
{
    public class ReplacementImplementationTaskThree : IReplacementImplementation
    {
        private readonly char _separator = '-';

        public string ReplaceNumber(int number)
        {
            string result = "";
            string str1 = "good" + _separator + "boy";

            if (number % 3 == 0)
                result += "dog" + _separator;

            if (number % 5 == 0)
                result += "cat" + _separator;

            if (number % 3 == 0 && number % 5 == 0)
                result = str1 + _separator;

            if (number % 4 == 0)
            {
                if (!result.Contains(str1))
                    result = ReplaceNumberTaskOne(number);
                result += "muzz" + _separator;
            }

            if (number % 7 == 0)
            {
                if (!result.Contains(str1))
                    result = ReplaceNumberTaskOne(number);
                result += "guzz" + _separator;
            }

            result = (result != "") ? result[..^1] : "";

            return result;
        }

        private string ReplaceNumberTaskOne(int number)
        {
            string result = "";

            if (number % 3 == 0)
                result += "fizz" + _separator;

            if (number % 5 == 0)
                result += "buzz" + _separator;

            return result;
        }
    }
}
