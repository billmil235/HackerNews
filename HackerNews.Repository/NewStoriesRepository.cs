using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HackerNews.Repository.Entities;
using HackerNews.Repository.Interfaces;

namespace HackerNews.Repository
{
    public class NewStoriesRepository : INewStoriesRepository
    {

        private readonly HttpClient _client;

        public NewStoriesRepository()
        {

            _client = new HttpClient();

        }

        /// <summary>
        /// Used to retrieve the list of all stories returned by the /newstories API call.
        /// </summary>
        /// <returns>A task associated with the API request.</returns>
        public async Task<IEnumerable<int>> GetNewStoryIdList()
        {

            var path = "https://hacker-news.firebaseio.com/v0/newstories.json";
            int[] storyIdList = null;

            HttpResponseMessage response = await _client.GetAsync(path);

            if(response.IsSuccessStatusCode)
            {
                storyIdList = await response.Content.ReadAsAsync<int[]>();
            }

            return storyIdList.OfType<int>().ToList();

        }

        public async Task<Story> GetStoryById(int id)
        {

            var path = $"https://hacker-news.firebaseio.com/v0/item/{id}.json";
            Story story = null;

            HttpResponseMessage response = await _client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                story = await response.Content.ReadAsAsync<Story>();
            }

            return story;

        }

    }
}
