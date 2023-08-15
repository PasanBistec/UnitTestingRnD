using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingRnD.Tests.Unit
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void ShouldInputTwoIntsAndAddThemReturnInt()
        {
            // given
            var calcService = new CalculatorService();
            var randomIntA = 2;
            var randomIntB = 3;
            var expectedValue = 5;

            //when
            var actualValue = calcService.AddTwoInts(randomIntB, randomIntA);

            // then

            Assert.Equal(expectedValue, actualValue);   

        }

        [Fact]
        public void ShouldInputTwoDoublesAndAddThemReturnInt()
        {
            // given
            var calcService = new CalculatorService();
            var randomDoubleA = 5.21;
            var randomDoubleB = 4.51;
            var expectedValue = 9.72;

            //when
            var actualValue = calcService.AddTwoDoubles(randomDoubleA, randomDoubleB);

            // then

            Assert.Equal(expectedValue, actualValue,2);

        }

    }
}
