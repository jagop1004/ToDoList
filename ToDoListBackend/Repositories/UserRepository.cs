using ToDoListBackend.Functionality;
using ToDoListBackend.Models;
namespace ToDoListBackend.Repositories
{
    public class UserRepository: Repository
    {
        private readonly DatabaseManagment db;
        public UserRepository(DatabaseManagment db)
        {
            this.db = db;
        }
        public override IEnumerable<Users> GetAll()
        {
            return db.Users.ToList();
        }
        public override Users GetById(int id)
        {
            return new Users();
        }
        public override bool WriteById(int id)
        {
            return true;
        }
        public override bool Create(IDataStructure data)
        {
            return true;
        }
        public override bool DeleteById(int id)
        {
            return true;
        }

    }
}
