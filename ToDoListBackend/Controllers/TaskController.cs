using Microsoft.AspNetCore.Mvc;

namespace ToDoListBackend.Controllers
{
    [ApiController]
    [Route("/todolist/[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet(Name = "GetTasks")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Task 1", "Task 2", "Task 3" };
        }

        [HttpPost(Name = "PostTask")]
        public IActionResult Post()
        {
            return BadRequest();
        }
    }

    
    
}
