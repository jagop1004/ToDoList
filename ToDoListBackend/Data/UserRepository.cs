using ToDoListBackend.Services;
using ToDoListBackend.Models;
namespace ToDoListBackend.Data
{
    public class UserRepository: Repository 
    {
        public UserRepository()
        {
        }
        public override IEnumerable<User> GetAll(DatabaseManagment db)
        {
            return db.Users.ToList();
        }
        public override User GetById(DatabaseManagment db, int id)
        {
            User foundUser = db.Users.Find(id);
            return foundUser;
        }
        public override bool WriteById(DatabaseManagment db, int id)
        {
            return true;
        }
        public override bool Create(DatabaseManagment db, IDataStructure data)
        {
            return true;
        }
        public override bool DeleteById(DatabaseManagment db, int id)
        {
            return true;
        }

    }
}
