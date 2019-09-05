using System;
namespace HackerNews.Repository.Entities.Properties
{
    public class PollOption : Base
    {
        public PollOption()
        {
        }

        /// <summary>
        /// The id of the poll this option is associated with.
        /// </summary>
        public int parent { get; set; }

        /// <summary>
        /// The number of votes for this option.
        /// </summary>
        public int score { get; set; }

    }
}
