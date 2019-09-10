using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HackerNews.Repository.Interfaces;
using HackerNews.Web.Logic.Interfaces;
using HackerNews.Web.Logic.Models;
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
        public IActionResult Get()
        {

            try
            {
                var newStoryList = _newStoryList.GetNewStoryList(null);
                return Ok(newStoryList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // GET: api/NewStories/10
        [HttpGet("{limitTo}")]
        public IActionResult Get(int limitTo)
        {

            try
            {
                var newStoryList = _newStoryList.GetNewStoryList(limitTo);
                return Ok(newStoryList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
