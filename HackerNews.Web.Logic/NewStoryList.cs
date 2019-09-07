using System;
using System.Collections.Generic;
using System.Linq;
using HackerNews.Repository.Entities;
using HackerNews.Repository.Interfaces;
using HackerNews.Web.Logic.Interfaces;

namespace HackerNews.Web.Logic
{
    public class NewStoryList : INewStoryList
    {

        public INewStoriesRepository _newStoriesRepository;

        public NewStoryList(INewStoriesRepository newStoriesRepository)
        {
            _newStoriesRepository = newStoriesRepository;
        }

        /// <summary>
        /// Retrieves a list of new stories from the /newstories API call.
        /// </summary>
        /// <param name="limitTo">Limits the number of stories returned.</param>
        /// <returns>A list of new stories.</returns>
        public List<Story> GetNewStoryList(int? limitTo = null)
        {

            var storyList = new List<Story>();
            var idList = GetNewStoryIdList(limitTo);

            foreach(var id in idList)
            {
                var story = GetStoryById(id);
                storyList.Add(story);
            }

            return storyList;

        }

        #region PrivateMethods

        /// <summary>
        /// Retrieves the specified story by the ID
        /// </summary>
        /// <param name="id">The id of the story to retrieve.</param>
        /// <returns>A <see cref="Story"/>object representing the story.</returns>
        private Story GetStoryById(int id)
        {
            var story = _newStoriesRepository.GetStoryById(id).GetAwaiter().GetResult();
            return story;
        }

        /// <summary>
        /// Retrieve the list of story ids from the /newstories API call.
        /// </summary>
        /// <param name="limitTo">Limits the number of stories returned.</param>
        /// <returns>An list of IDs for new stories.</returns>
        private IEnumerable<int> GetNewStoryIdList(int? limitTo = null)
        {
            var idList = _newStoriesRepository.GetNewStoryIdList().GetAwaiter().GetResult();

            if (limitTo.HasValue)
            {
                idList = idList.Take(limitTo.Value);
            }

            return idList;
        }

        #endregion

    }
}
