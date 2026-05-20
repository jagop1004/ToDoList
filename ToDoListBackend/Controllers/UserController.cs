using Microsoft.AspNetCore.Mvc;

namespace ToDoListBackend.Controllers
{
    [ApiController]
    [Route("/todolist/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "GetUsers")]
        public IEnumerable<string> Get()
        {
            return new string[] { "User 1", "User 2", "User 3" };
        }
    }
}
