using System;
using HackerNews.Repository.Entities;
using HackerNews.Web.Logic.Models;

namespace HackerNews.Web.Logic.Utilities
{
    public interface IStoryMapper
    {

        Models.Story MapStory(Repository.Entities.Story story);
        DateTime GetDotNetTimeFromUnixTime(int time);

    }
}
