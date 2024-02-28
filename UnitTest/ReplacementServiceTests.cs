using NumberReplacementService.ReplacementImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberReplacementService.UnitTest
{
    [TestClass]
    public class ReplacementServiceTests
    {
        private IReplacementService _replacementService;
        private IReplacementImplementation _replacementImplementation;

        [TestInitialize]
        public void SetUp()
        {
            _replacementService = new ReplacementService();
        }

        [TestMethod]
        public void ReplaceNumbers_WithExampleInput1_ReturnsExpectedOutput1()
        {
            _replacementImplementation = new ReplacementImplementationTaskOne();

            List<int> input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<string> expectedOutput = new() { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizz-buzz" };

            List<string> actualOutput = _replacementService.ReplaceNumbers(input, _replacementImplementation);

            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReplaceNumbers_WithExampleInput2_ReturnsExpectedOutput2()
        {
            _replacementImplementation = new ReplacementImplementationTaskTwo();

            List<int> input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> expectedOutput = new() { "1", "2", "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", "11", "fizz-muzz", "13", "guzz", "fizz-buzz", "fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz" };

            List<string> actualOutput = _replacementService.ReplaceNumbers(input, _replacementImplementation);

            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReplaceNumbers_WithExampleInput3_ReturnsExpectedOutput3()
        {
            _replacementImplementation = new ReplacementImplementationTaskThree();

            List<int> input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> expectedOutput = new() { "1", "2", "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", "11", "fizz-muzz", "13", "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz" };

            List<string> actualOutput = _replacementService.ReplaceNumbers(input, _replacementImplementation);

            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
    }
}