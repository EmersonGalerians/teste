using Sample.Extension;
using System;
using Xunit;

namespace Sample.Test.Extensions
{
    public class DatetimeExtensionsTest
    {
        public DatetimeExtensionsTest()
        {

        }

        [Fact]
        public void Should_DatetimeToStringShortPtBR_ReturnSuccess()
        {
            //arrange
            var dateTest = DateTime.Now;
            var expectedQtdChar = 10;
            var expectedQtdParts = 3;
            var characterSeparatorDate = "/";
            var maxValueMonth = 12;

            //act
            var result = dateTest.ToStringShortPtBR();
            var resultSplit = result.Split(characterSeparatorDate);

            //assert
            Assert.True(int.Parse(resultSplit[1]) <= maxValueMonth);
            Assert.Equal(expectedQtdParts, resultSplit.Length);
            Assert.Equal(expectedQtdChar, result.Length);
        }

        [Fact]
        public void Should_DatetimeToStringShortPtBR_ReturnFalse()
        {
            //arrange
            var dateTest = DateTime.MinValue;

            //act & assert
            Assert.Throws<ArgumentNullException>(() => dateTest.ToStringShortPtBR());
        }
        [Theory]
        [InlineData(2022, 02, 10, 01, 12, 20)]
        [InlineData(2022, 20, 01, 01, 10, 20)]
        public void Should_DateTimeToStringPtBR_ReturnFalse(int Y, int M, int D, int H, int m, int S)
        {

            
            var date = new DateTime( Y,  M,  D,  H,  m,  S);
            var result = date.ToStringPtBR();
            var resultSplit = result.Split("/");
            Assert.True(bool.Parse(result));
        }
    }
}