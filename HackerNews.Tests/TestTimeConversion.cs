using System;
using System.Diagnostics;
using HackerNews.Web.Logic.Utilities;
using Moq;
using Xunit;

namespace HackerNews.Tests
{
    public class TestTimeConversion
    {

        [Theory]
        [InlineData(1568079800, "01:43:20")]
        public void TestTimeConversionFromUnixTimeStamp(int timeStamp, string expected)
        {

            var storyMapper = new StoryMapper();
            var outDateTime = storyMapper.GetDotNetTimeFromUnixTime(timeStamp);
            Assert.Equal(outDateTime.ToLongTimeString(), expected);

        }

    }
}