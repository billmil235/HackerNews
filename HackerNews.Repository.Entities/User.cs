using System;
namespace HackerNews.Repository.Entities
{
    public class User
    {
        public User()
        {
        }

        /// <summary>
        /// The users id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Delay in minutes between when a comment is created and it becomes visible.
        /// </summary>
        public int delay { get; set; }

        /// <summary>
        /// The time when the user was created in UNIX time.
        /// </summary>
        public int created { get; set; }

        /// <summary>
        /// the user's karma.
        /// </summary>
        public int karma { get; set; }

        /// <summary>
        /// A html formatted string describing the user.
        /// </summary>
        public string about { get; set; }

        /// <summary>
        /// A list of the items submitted by the user.
        /// </summary>
        public int[] submitted { get; set; }

    }
}
