using System;
using HackerNews.Web.Logic.Models;
using HackerNews.Repository.Entities;

namespace HackerNews.Web.Logic.Utilities
{
    public class StoryMapper : IStoryMapper
    {
        public StoryMapper()
        {
        }

        public Models.Story MapStory(Repository.Entities.Story story)
        {

            return new Models.Story()
            {
                Author = story.by,
                PostTime = GetDotNetTimeFromUnixTime(story.time),
                Score = story.score,
                Title = story.title,
                URL = story.url
            };

        }

        public DateTime GetDotNetTimeFromUnixTime(int time)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(time);
        }

    }
}
