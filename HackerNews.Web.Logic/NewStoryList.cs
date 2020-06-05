using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.Repository.Entities;
using HackerNews.Repository.Interfaces;
using HackerNews.Web.Logic.Interfaces;
using HackerNews.Web.Logic.Models;
using HackerNews.Web.Logic.Utilities;

namespace HackerNews.Web.Logic
{
    public class NewStoryList : INewStoryList
    {

        public INewStoriesRepository _newStoriesRepository;
        public IStoryMapper _storyMapper;

        public NewStoryList(INewStoriesRepository newStoriesRepository, IStoryMapper storyMapper)
        {
            _newStoriesRepository = newStoriesRepository;
            _storyMapper = storyMapper;
        }

        /// <summary>
        /// Retrieves a list of new stories from the /newstories API call.
        /// </summary>
        /// <param name="limitTo">Limits the number of stories returned.</param>
        /// <returns>A list of new stories.</returns>
        public async Task<List<Models.Story>> GetNewStoryListAsync(int? limitTo = null)
        {

            var storyList = new List<Models.Story>();
            var idList = await GetNewStoryIdListAsync(limitTo);

            foreach(var id in idList)
            {
                var story = await GetStoryByIdAsync(id);
                storyList.Add(_storyMapper.MapStory(story));
            }

            return storyList;

        }

        #region PrivateMethods

        /// <summary>
        /// Retrieves the specified story by the ID
        /// </summary>
        /// <param name="id">The id of the story to retrieve.</param>
        /// <returns>A <see cref="Story"/>object representing the story.</returns>
        private async Task<Repository.Entities.Story> GetStoryByIdAsync(int id)
        {
            var story = await _newStoriesRepository.GetStoryById(id);
            return story;
        }

        /// <summary>
        /// Retrieve the list of story ids from the /newstories API call.
        /// </summary>
        /// <param name="limitTo">Limits the number of stories returned.</param>
        /// <returns>An list of IDs for new stories.</returns>
        private async System.Threading.Tasks.Task<IEnumerable<int>> GetNewStoryIdListAsync(int? limitTo = null)
        {
            var idList = await _newStoriesRepository.GetNewStoryIdListAsync();

            if (limitTo.HasValue)
            {
                idList = idList.Take(limitTo.Value);
            }

            return idList;
        }

        #endregion

    }
}
