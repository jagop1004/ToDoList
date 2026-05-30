using Microsoft.AspNetCore.Mvc;
using ToDoListBackend.Services;
using ToDoListBackend.Data;
namespace ToDoListBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly ToDoManagment _toDoManager;

        public ToDoListController(DatabaseManagment _dbContext)
        {
            _toDoManager = new ToDoManagment(_dbContext);
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            //var dbResult = _toDoManager.GetAllUsers();
            return Ok();
        }
    }
}
