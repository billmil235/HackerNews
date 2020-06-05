using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HackerNews.Web.Logic.Models;

namespace HackerNews.Web.Logic.Interfaces
{
    public interface INewStoryList
    {

        /// <summary>
        /// Retrieves a list of new stories from the /newstories API call.
        /// </summary>
        /// <param name="limitTo">Limits the number of stories returned.</param>
        /// <returns>A list of new stories.</returns>
        Task<List<Story>> GetNewStoryListAsync(int? limitTo = null);

    }
}
