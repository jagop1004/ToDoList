using ToDoListBackend.Services;
using ToDoListBackend.Models;
namespace ToDoListBackend.Data
{
    public class BoardRepository: Repository 
    {
        public BoardRepository()
        {
        }
        public override IEnumerable<Board> GetAll(DatabaseManagment db)
        {
            return db.Boards.ToList();
        }
        public override Board GetById(DatabaseManagment db, int id)
        {
            Board foundBoard = db.Boards.Find(id);
            return foundBoard;
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
