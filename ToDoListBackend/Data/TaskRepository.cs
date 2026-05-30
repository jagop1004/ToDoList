using ToDoListBackend.Services;
using ToDoListBackend.Models;
namespace ToDoListBackend.Data
{
    public class TaskRepository: Repository 
    {
        public TaskRepository()
        {
        }
        public override IEnumerable<ToDoListBackend.Models.Task> GetAll(DatabaseManagment db)
        {
            return db.Tasks.ToList();
        }
        public override ToDoListBackend.Models.Task GetById(DatabaseManagment db, int id)
        {
            ToDoListBackend.Models.Task foundTask = db.Tasks.Find(id);
            return foundTask;
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
