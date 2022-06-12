using Microsoft.AspNetCore.Mvc;
using Snake.API.Models;

namespace Snake.API
{
    [Route("api/Snake")]
    public class SnakeApiController : ControllerBase
    {
        [HttpGet]
        public Task<APIDetailsDTO> GetSomething()
            => Task.FromResult(new APIDetailsDTO());

        [HttpPut("start")]
        public Task<APIDetailsDTO> StartNewGame()
            => Task.FromResult(new APIDetailsDTO());
    }
}