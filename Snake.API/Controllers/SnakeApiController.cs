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
        public Task StartNewGame([FromBody] InstanceDTO gameBoardDetails)
        {
            return Task.CompletedTask;
        }

        [HttpPost("move")]
        public Task<MoveDTO> MakeAMove([FromBody] InstanceDTO gameBoardDetails)
            => Task.FromResult(new MoveDTO { move = "up" });
    }
}