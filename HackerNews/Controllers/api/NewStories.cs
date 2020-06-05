using System;
using System.Threading.Tasks;
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
        public async Task<IActionResult> GetAsync()
        {

            try
            {
                var newStoryList = await _newStoryList.GetNewStoryListAsync(null);
                return Ok(newStoryList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // GET: api/NewStories/10
        [HttpGet("{limitTo}")]
        public async Task<IActionResult> GetAsync(int limitTo)
        {

            try
            {
                var newStoryList = await _newStoryList.GetNewStoryListAsync(limitTo);
                return Ok(newStoryList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
