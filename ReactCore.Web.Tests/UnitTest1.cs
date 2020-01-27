using System;
using Xunit;

namespace ReactCore.Web.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestOneEqualsOne()
        {
            Assert.Equal(1, 1);
        }

        [Theory]
        [InlineData(2, 2, true)]
        [InlineData(2, 3, false)]
        public void TestValueEqualsItself(int valueA, int valueB, bool isEqualExpected)
        {
            if (isEqualExpected)
            {
                Assert.Equal(valueA, valueB);
            }
            else
            {
                Assert.NotEqual(valueA, valueB);
            }
            
        }
    }
}
