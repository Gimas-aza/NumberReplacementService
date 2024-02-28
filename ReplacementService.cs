namespace NumberReplacementService
{
    public class ReplacementService : IReplacementService
    {
        public List<string> ReplaceNumbers(List<int> numbers, IReplacementImplementation replacement)
        {
            var result = new List<string>();

            foreach (var number in numbers)
            {
                string replace = replacement.ReplaceNumber(number);

                if (string.IsNullOrEmpty(replace))
                    replace = number.ToString();

                result.Add(replace);
            }

            return result;
        }
    }
}
