using System;
namespace HackerNews.Repository.Entities
{
    public class Poll : Base
    {
        public Poll()
        {
        }

        /// <summary>
        /// A list of the relevant poll options.
        /// </summary>
        public int[] parts { get; set; }

        /// <summary>
        /// The number of comments.
        /// </summary>
        public int descendents { get; set; }

        /// <summary>
        /// The votes for the poll options.
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// The title of the poll.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The text of the poll.
        /// </summary>
        public string text { get; set; }

    }
}
