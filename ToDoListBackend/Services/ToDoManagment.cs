using ToDoListBackend.Models;
using ToDoListBackend.Data;

namespace ToDoListBackend.Services
{
    public class ToDoManagment : IToDoManagment
    {
        private readonly DatabaseManagment _databaseConnection;
        private UserRepository _userRepository;

        public ToDoManagment(DatabaseManagment databaseConnection)
        {
            _databaseConnection = databaseConnection;
            _userRepository = new UserRepository();

        }
    }

    public interface IToDoManagment
    {
    }
}
