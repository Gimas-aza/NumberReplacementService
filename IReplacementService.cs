namespace NumberReplacementService
{
    internal interface IReplacementService
    {
        List<string> ReplaceNumbers(List<int> numbers, IReplacementImplementation replacement);
    }
}
