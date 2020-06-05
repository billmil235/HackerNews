using System.Collections.Generic;
using System.Threading.Tasks;
using HackerNews.Repository.Entities;

namespace HackerNews.Repository.Interfaces
{
    public interface INewStoriesRepository
    {

        /// <summary>
        /// Used to retrieve the list of all stories returned by the /newstories API call.
        /// </summary>
        /// <returns>A task associated with the API request.</returns>
        Task<IEnumerable<int>> GetNewStoryIdListAsync();

        /// <summary>
        /// Used to retrieve a specific story based on its ID number.
        /// </summary>
        /// <param name="id">The ID of the story to retrieve.</param>
        /// <returns>A <see cref="Story"/> object.</returns>
        Task<Story> GetStoryById(int id);

    }
}
