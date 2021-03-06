using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class ValidParenthesesTest
    {
        [Theory]
        [InlineData("()[]{}", true)]
        [InlineData("([)]", false)]
        public void TestMethod(string s, bool output)
        {
            Assert.Equal(output, Solution020.IsValid(s));
        }
    }
}

