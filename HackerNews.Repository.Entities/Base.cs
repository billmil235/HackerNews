using System;
namespace HackerNews.Repository.Entities
{
    public class Base
    {

        public Base()
        {
        }

        /// <summary>
        /// The item's unique id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// if the item has been deleted.
        /// </summary>
        public bool deleted { get; set; }

        /// <summary>
        /// The type of item.  Valid values are job, story, comment, poll or pollopt
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// The username of the items author.
        /// </summary>
        public string by { get; set; }

        /// <summary>
        /// Creation date of the item in UNIX time.
        /// </summary>
        public int time { get; set; }

        /// <summary>
        /// If the item is dead.
        /// </summary>
        public bool dead { get; set; }

        /// <summary>
        /// The ids of the items comments in ranked display order.
        /// </summary>
        public int[] kids { get; set; }

    }
}
