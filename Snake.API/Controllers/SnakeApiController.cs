using Microsoft.AspNetCore.Mvc;
using Snake.API.Models;

namespace Snake.API
{
    [Route("api/Snake")]
    public class SnakeApiController : ControllerBase
    {
        [HttpGet]
        public Task<APIDetailsDTO> GetAPIDetails()
            => Task.FromResult(new APIDetailsDTO());

        [HttpPut("start")]
        public Task StartNewGame([FromBody] InstanceDTO gameBoardDetails)
            => Task.CompletedTask;

        [HttpPost("move")]
        public Task<MoveDTO> MakeAMove([FromBody] InstanceDTO gameBoardDetails)
            => Task.FromResult(new MoveDTO { move = "up" });

        [HttpPost("end")]
        public Task EndGame([FromBody] InstanceDTO gameBoardDetails)
            => Task.CompletedTask;
    }
}