using System;
namespace HackerNews.Repository.Entities
{
    public class Job  : Base
    {
        public Job()
        {
        }

        /// <summary>
        /// The text of the job.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// The URL of the job.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The title of the job.
        /// </summary>
        public string title { get; set; }

    }
}
