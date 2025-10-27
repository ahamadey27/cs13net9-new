using Exercise_PrimeFactorsLib;
using System;
using Xunit;

namespace Exercise_PrimeFactorsTests;

public class PrimeFactorsTests
{
    [Fact]
    public void Test1()
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "2 x 2")]
        [InlineData(360, "2 x 2 x 2 x 3 x 3 x 5")]
        public void ReturnsExpectedString(int input, string expected)
        {
            string actual = PrimeFactors.PrimeFactors(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Negative_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PrimeFactors.PrimeFactors(0));
        }

    }
}
