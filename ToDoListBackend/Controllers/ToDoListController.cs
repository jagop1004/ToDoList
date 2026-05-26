using Microsoft.AspNetCore.Mvc;
using ToDoListBackend.Functionality;

namespace ToDoListBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly ToDoManagment _toDoManager;
        public ToDoListController(ToDoManagment toDoManager)
        {
            _toDoManager = toDoManager;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            //var dbResult = _toDoManager.GetAllUsers();
            return Ok();
        }
    }
}
