using Microsoft.AspNetCore.Mvc;
using Snake.API.Models;

namespace Snake.API
{
    [Route("api/Snake")]
    public class SnakeApiController : ControllerBase
    {
        [HttpGet]
        public Task<SnakeBoardDTO> GetSomething()
            => Task.FromResult(new SnakeBoardDTO());
    }
}