using ToDoListBackend.Models;
using ToDoListBackend.Repositories;

namespace ToDoListBackend.Functionality
{
    public class ToDoManagment : IToDoManagment
    {
        private readonly DatabaseManagment _databaseConnection;
        private UserRepository _userRepository;
        

        public ToDoManagment(DatabaseManagment databaseConnection)
        {
            _databaseConnection = databaseConnection;
            _userRepository = new UserRepository(_databaseConnection);

        }

        public IEnumerable<Users> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

    }

    public interface IToDoManagment
    {
        
    }
}
