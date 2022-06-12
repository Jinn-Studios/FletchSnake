using Microsoft.AspNetCore.Mvc;
using Snake.API.Models;

namespace Snake.API
{
    [Route("api/Snake")]
    public class SnakeApiController : ControllerBase
    {
        [HttpGet]
        public Task<SnakeAPIDetailsDTO> GetSomething()
            => Task.FromResult(new SnakeAPIDetailsDTO());

        [HttpPut("start")]
        public Task<SnakeAPIDetailsDTO> StartNewGame()
            => Task.FromResult(new SnakeAPIDetailsDTO());
    }
}