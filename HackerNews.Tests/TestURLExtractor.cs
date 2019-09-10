using System;
using HackerNews.Web.Logic.Utilities;
using Xunit;

namespace HackerNews.Tests
{
    public class TestURLExtractor
    {
        public TestURLExtractor()
        {
        }

        [Theory]
        [InlineData("https://protonmail.com/blog/security-updates-2019/", "protonmail.com")]
        public void TestURLExtraction(string url, string expected)
        {

            var storyMapper = new StoryMapper();
            var outUrl = storyMapper.GetDomainFromURI(url);
            Assert.Equal(outUrl, expected);

        }

    }
}
