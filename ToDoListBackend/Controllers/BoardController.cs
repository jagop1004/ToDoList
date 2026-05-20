using Microsoft.AspNetCore.Mvc;

namespace ToDoListBackend.Controllers
{
    [ApiController]
    [Route("/todolist/[controller]")]
    public class BoardController : ControllerBase
    {
        [HttpGet(Name = "GetBoards")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Board 1", "Board 2", "Board 3" };
        }
    }
}
