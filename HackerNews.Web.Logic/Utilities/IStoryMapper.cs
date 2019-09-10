using System;
using HackerNews.Repository.Entities;
using HackerNews.Web.Logic.Models;

namespace HackerNews.Web.Logic.Utilities
{
    public interface IStoryMapper
    {

        /// <summary>
        /// Converts between the story entity and the story web model.
        /// </summary>
        /// <param name="story">A story entity to be converted.</param>
        /// <returns>A web model of the story.</returns>
        Models.Story MapStory(Repository.Entities.Story story);

        /// <summary>
        /// Converts a UNIX timestamp to a .Net DateTime.
        /// </summary>
        /// <param name="time">The UNIX timestamp to be converted.</param>
        /// <returns>A .Net DateTime representation of the UNIX time stamp.</returns>
        DateTime GetDotNetTimeFromUnixTime(int time);

        /// <summary>
        /// Extracts the domain from a full URL.
        /// </summary>
        /// <param name="uri">The full URL to have the domain extracted from.</param>
        /// <returns>A string containing the domain.</returns>
        string GetDomainFromURI(string uri);

    }
}
