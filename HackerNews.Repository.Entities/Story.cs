using System;
namespace HackerNews.Repository.Entities
{
    public class Story : Base
    {
        public Story()
        {
        }

        /// <summary>
        /// The total comment count
        /// </summary>
        public int descendants { get; set; }

        /// <summary>
        /// The story's score.
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// The title of the story.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The URL of the story.
        /// </summary>
        public string url { get; set; }

    }
}
