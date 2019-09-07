using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.Repository.Entities;
using HackerNews.Repository.Interfaces;
using HackerNews.Web.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackerNews.Web.Controllers.api
{
    [Route("api/[controller]")]
    public class NewStories : Controller
    {

        public INewStoryList _newStoryList;

        public NewStories(INewStoryList newStoryList)
        {
            _newStoryList = newStoryList;
        }

        // GET: api/NewStories
        [HttpGet]
        public List<Story> Get()
        {
            var newStoryList = _newStoryList.GetNewStoryList(null);
            return newStoryList;
        }

        // GET: api/NewStories?limitTo=10
        [HttpGet("{limitTo}")]
        public List<Story> Get(int limitTo)
        {
            var newStoryList = _newStoryList.GetNewStoryList(limitTo);
            return newStoryList;
        }

    }
}
