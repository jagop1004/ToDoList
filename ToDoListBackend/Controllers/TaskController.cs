using Microsoft.AspNetCore.Mvc;
using ToDoListBackend.Functionality;

namespace ToDoListBackend.Controllers
{
    [ApiController]
    [Route("/todolist/[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet(Name = "GetTasks")]
        public IActionResult Get(int? id)
        {
            if(id == null)
                return Ok(TaskManagment.GetTask());
            else return Ok(TaskManagment.GetTask((int)id));
        }
        [HttpGet("all", Name = "GetAllTasks")]
        public IActionResult GetAll()
        {
            return Ok(TaskManagment.GetAllTasks());
        }

        [HttpPost(Name = "PostTask")]
        public IActionResult Post()
        {
            return BadRequest();
        }
    }

    
    
}
