using System.Collections.Generic;
using Xunit;

namespace AIC.Functionality.Tests
{
    public class AlgorithmTests
    {
        [Fact]
        public void CanFormatSeparators()
        {
            var list = new List<string> { "red", "green", "purple", "yellow", "pink" };

            Assert.Equal("red, green, purple, yellow, and pink!", Algorithms.BuildFormattedString(list));
        }


        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Fact]
        public void CalculateFibonacciSequence()
        {
            var results = FibonacciSequence.fibonacci(10);

            Assert.Equal(34, results[^1]);
        }

        [Fact(Skip = "Ignore this functionality")]
        public void CalculateMinimumMoves()
        {
            var arr1 = new List<int> { 123, 543 };
            var arr2 = new List<int> { 321, 279 };

            var result = MoveCount.MinimumMoves(arr1, arr2);
            Assert.Equal(16, result);

            var arr3 = new List<int> { 1234, 4321 };
            var arr4 = new List<int>{2345, 3214};
            result = MoveCount.MinimumMoves(arr3, arr4);
            Assert.Equal(10, result);

        }
    }
}
