using System;

namespace HackerNews.Web.Logic.Utilities
{
    public class StoryMapper : IStoryMapper
    {
        public StoryMapper()
        {
        }

        /// <summary>
        /// Converts between the story entity and the story web model.
        /// </summary>
        /// <param name="story">A story entity to be converted.</param>
        /// <returns>A web model of the story.</returns>
        public Models.Story MapStory(Repository.Entities.Story story)
        {

            return new Models.Story()
            {
                Author = story.by,
                PostTime = GetDotNetTimeFromUnixTime(story.time),
                Score = story.score,
                Title = story.title,
                URL = story.url,
                Domain = GetDomainFromURI(story.url)
            };

        }

        /// <summary>
        /// Converts a UNIX timestamp to a .Net DateTime.
        /// </summary>
        /// <param name="time">The UNIX timestamp to be converted.</param>
        /// <returns>A .Net DateTime representation of the UNIX time stamp.</returns>
        public DateTime GetDotNetTimeFromUnixTime(int time)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(time);
        }

        /// <summary>
        /// Extracts the domain from a full URL.
        /// </summary>
        /// <param name="uri">The full URL to have the domain extracted from.</param>
        /// <returns>A string containing the domain.</returns>
        public string GetDomainFromURI(string uri)
        {

            string host = "";

            // Some stories can come through with a NULL uri.
            if (uri != null)
            {
                Uri myUri = new Uri(uri);
                host = myUri.Host;
            }

            return host;

        }

    }
}
