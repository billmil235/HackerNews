using System;
using System.Collections.Generic;

namespace HackerNews.Web.Logic.Interfaces
{
    public interface INewStoryList
    {

        /// <summary>
        /// Retrieves a list of new stories from the /newstories API call.
        /// </summary>
        /// <param name="limitTo">Limits the number of stories returned.</param>
        /// <returns>A list of new stories.</returns>
        List<int> GetNewStoryList(int? limitTo = null);

    }
}
