using System;
namespace HackerNews.Repository.Entities
{
    public class Comment : Base
    {
        public Comment()
        {
        }

        /// <summary>
        /// The item's parent, either another comment or the story.
        /// For poll option, the poll.
        /// </summary>
        public string parent { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        public string text { get; set; }

    }
}
