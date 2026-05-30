using ToDoListBackend.Models;
using ToDoListBackend.Data;

namespace ToDoListBackend.Services
{
    public class ToDoManagment : IToDoManagment
    {
        private readonly DatabaseManagment _databaseConnection;
        private UserRepository _userRepo;
        private BoardRepository _boardRepo;
        private TaskRepository _taskRepo;

        public ToDoManagment(DatabaseManagment databaseConnection)
        {
            _databaseConnection = databaseConnection;
            _userRepo = new UserRepository();
            _boardRepo = new BoardRepository();
            _taskRepo = new TaskRepository();
        }
    }

    public interface IToDoManagment
    {
    }
}
