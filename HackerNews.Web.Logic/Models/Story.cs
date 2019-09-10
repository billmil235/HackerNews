using System;
namespace HackerNews.Web.Logic.Models
{
    public class Story
    {

        public Story()
        {
        }

        public int Score { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }

        public string Domain { get; set; }

        public DateTime PostTime { get; set; }

    }
}
